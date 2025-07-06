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
            var counter = 1;

            // 1. Группируем паллеты по их сроку годности
            var groupedPallets = pallets
                .GroupBy(p => p.ExpirationDate)
                .OrderBy(g => g.Key);

            foreach (var group in groupedPallets)
            {
                // Вставляем "заголовок группы"
                palletData.Add(new PalletInfo
                {
                    PalletID = -1, // -1 чтобы распознать как заголовок
                    GroupHeader = $"Группа {counter++}"
                });

                // Сортируем внутри группы по весу
                var sorted = group.OrderBy(p => p.Weight);

                foreach (var pallet in sorted)
                {
                    palletData.Add(new PalletInfo
                    {
                        ExpirationDate = pallet.ExpirationDate,
                        PalletID = pallet.ID,
                        Weight = pallet.Weight,
                        Volume = pallet.Volume,
                        GroupHeader = ""
                    });
                }
            }

            // 2. Добавим блок: 3 паллеты с максимальным сроком годности
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
                PalletID = -1,
                GroupHeader = "Топ 3 паллеты"
            });

            foreach (var item in top3)
            {
                palletData.Add(new PalletInfo
                {
                    ExpirationDate = item.MaxExpiration,
                    PalletID = item.Pallet.ID,
                    Weight = item.Pallet.Weight,
                    Volume = item.Pallet.Volume,
                    GroupHeader = ""
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
    }

    // Класс для хранения информации о паллете для отображения в DataGridView
    public class PalletInfo
    {
        public string GroupHeader { get; set; } // Заголовок группы
        public DateTime? ExpirationDate { get; set; }
        public int PalletID { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
    }
}
