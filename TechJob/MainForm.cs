using System.Drawing;
using Npgsql;

namespace TechJob
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var pallets = new List<Pallet>();

            for (int i = 1; i <= 10; i++)
            {
                var pallet = new Pallet(i, 120, 80, 100);
                int boxCount = rnd.Next(2, 6); // �� 2 �� 5 �������

                for (int j = 0; j < boxCount; j++)
                {
                    int boxId = i * 10 + j;
                    double length = rnd.Next(20, 61); // 20�60 ��
                    double width = rnd.Next(20, 61);
                    double height = rnd.Next(10, 41);
                    double weight = Math.Round(rnd.NextDouble() * 10 + 1, 2); // 1�11 ��
                    DateTime expiration = DateTime.Now.AddDays(rnd.Next(-10, 31)); // �� -10 �� +30 ����

                    pallet.Boxes.Add(new Box(boxId, length, width, height, weight, expiration.Date));
                }

                pallets.Add(pallet);
            }

            var listform = new ListForm(pallets);
            listform.ShowDialog();
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
