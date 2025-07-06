using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechJob
{
    public partial class ListForm : Form
    {
        public ListForm(List<Pallet> pallets)
        {
            InitializeComponent();
            LoadPalletsData(pallets);
        }

        private void LoadPalletsData(List<Pallet> pallets)
        {
            var palletData = new List<PalletInfo>();
            var group_counter = 1;
            var pallet_counter = 1;

            // Группировка паллет по сроку годности
            var groupedPallets = pallets
                .GroupBy(p => p.ExpirationDate)
                .OrderBy(g => g.Key);

            foreach (var group in groupedPallets)
            {
                palletData.Add(new PalletInfo
                {
                    GroupHeader = $"Группа {group_counter} (вес ↓)",
                });

                // Сортировка внутри группы по весу
                var sorted = group.OrderBy(p => p.Weight);

                foreach (var pallet in sorted)
                {
                    palletData.Add(new PalletInfo
                    {
                        GroupHeader = $"Паллета {group_counter}.{pallet_counter++}",
                        PalletID = pallet.ID,
                        Width = pallet.Width,
                        Height = pallet.Height,
                        Depth = pallet.Depth,
                        Weight = pallet.Weight,
                        Volume = pallet.Volume,
                        ExpirationDate = pallet.ExpirationDate,
                    });
                }

                pallet_counter = 1;
                group_counter++;
            }

            // 3 паллеты с максимальным сроком годности
            var top3 = pallets
                .Where(p => p.Boxes.Any())
                .Select(p => new
                {
                    Pallet = p,
                    MaxExpiration = p.Boxes.Max(b => b.ExpirationDate)
                })
                .OrderByDescending(x => x.MaxExpiration)
                .Take(3)
                .OrderBy(x => x.Pallet.Volume);

            palletData.Add(new PalletInfo
            {
                GroupHeader = "3 паллеты (объем ↓)"
            });

            foreach (var item in top3)
            {
                palletData.Add(new PalletInfo
                {
                    GroupHeader = "",
                    PalletID = item.Pallet.ID,
                    Width = item.Pallet.Width,
                    Height = item.Pallet.Height,
                    Depth = item.Pallet.Depth,
                    Weight = item.Pallet.Weight,
                    Volume = item.Pallet.Volume,
                    ExpirationDate = item.MaxExpiration,
                });
            }

            dataGridViewPallets.DataSource = palletData;
        }



        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewPallets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewPallets_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewPallets_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dataGridViewPallets.Rows[e.RowIndex];

            if (row.DataBoundItem is PalletInfo info && info.PalletID == null)
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue; // выделение цветом
                row.DefaultCellStyle.Font = new Font(dataGridViewPallets.Font, FontStyle.Bold);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class PalletInfo
    {
        public string GroupHeader { get; set; }
        public int? PalletID { get; set; }

        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Depth { get; set; }

        public double? Weight { get; set; }
        public double? Volume { get; set; }
        public DateTime? ExpirationDate { get; set; }

    }


}
