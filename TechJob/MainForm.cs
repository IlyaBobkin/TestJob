using System.Drawing;
using Npgsql;

namespace TechJob
{
    public partial class MainForm : Form
    {

        private List<Pallet> LoadPalletsAndBoxes()
        {
            string connStr = "Server=localhost;Port=5432;Database=my_database;User Id=postgres;Password=postgres;";
            var pallets = new Dictionary<int, Pallet>();

            try
            {
                using var connection = new NpgsqlConnection(connStr);
                connection.Open();

                // Загружаем паллеты
                using (var cmd = new NpgsqlCommand("SELECT * FROM Pallets", connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pallet = new Pallet(
                            reader.GetInt32(0), // Id
                            (double)reader.GetDecimal(1), // Width
                            (double)reader.GetDecimal(2), // Height
                            (double)reader.GetDecimal(3)  // Depth
                        );
                        pallets.Add(pallet.ID, pallet);
                    }
                }

                // Загружаем коробки
                using (var cmd = new NpgsqlCommand("SELECT * FROM Boxes", connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var box = new Box(
                            id: reader.GetInt32(0),
                            width: (double)reader.GetDecimal(1),
                            height: (double)reader.GetDecimal(2),
                            depth: (double)reader.GetDecimal(3),
                            weight: (double)reader.GetDecimal(4),
                            productionDate: reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5)
                        );

                        if (!reader.IsDBNull(6)) // PalletId
                        {
                            int palletId = reader.GetInt32(6);
                            if (pallets.TryGetValue(palletId, out var pallet))
                            {
                                pallet.Boxes.Add(box); // Добавляем коробку в список
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Логирование ошибки или обработка исключения
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }

            return new List<Pallet>(pallets.Values);
        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем тестовые данные
            var pallets = new List<Pallet>
            {
                new Pallet(1, 120, 80, 100)
                {
                    Boxes = new List<Box>
                    {
                        new Box(1, 30, 20, 10, 5, DateTime.Now.AddDays(-10).Date),
                        new Box(2, 30, 20, 10, 6, DateTime.Now.AddDays(-5).Date)
                    }
                },
                new Pallet(2, 120, 80, 100)
                {
                    Boxes = new List<Box>
                    {
                        new Box(3, 30, 20, 10, 7, DateTime.Now.AddDays(5).Date),
                        new Box(4, 30, 20, 10, 8, DateTime.Now.AddDays(15).Date)
                    }
                },
                new Pallet(3, 120, 80, 100)
                {
                    Boxes = new List<Box>
                    {
                        new Box(5, 30, 20, 10, 9, DateTime.Now.AddDays(25).Date),
                        new Box(6, 30, 20, 10, 10, DateTime.Now.AddDays(30).Date)
                    }
                }
            };
            var listform = new ListForm(pallets);
            listform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                }
                catch (IOException)
                {
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var listform = new ListForm(LoadPalletsAndBoxes());
            listform.ShowDialog();
        }
    
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
