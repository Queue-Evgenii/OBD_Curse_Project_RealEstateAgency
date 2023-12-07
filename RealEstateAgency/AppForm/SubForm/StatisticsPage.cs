using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateAgency.Statistic;

namespace RealEstateAgency
{
    public partial class App : Form
    {

        private void setStatisticPage()
        {
            Button statByDate = new Button();
            Button statByDistrict = new Button();
            Button statByRoomsAmount = new Button();

            statByDate.Text = "Статистика за датою";
            statByDistrict.Text = "Статистика за районами";
            statByRoomsAmount.Text = "Статистика за кількістю кімнат";

            statByDate.Width = statByDistrict.Width = statByRoomsAmount.Width = 250;
            statByDate.Height = statByDistrict.Height = statByRoomsAmount.Height = 40;

            statByDate.Font = statByDistrict.Font = statByRoomsAmount.Font = new Font("Arial", 12);

            statByDate.Click += (object sender, EventArgs e) =>
            {
                StatisticByDate form = new StatisticByDate(conn);
                form.Show();
            };

            statByDistrict.Click += (object sender, EventArgs e) =>
            {
                StatisticByDistrict form = new StatisticByDistrict(conn);
                form.Show();
            };

            statByRoomsAmount.Click += (object sender, EventArgs e) =>
            {
                StatisticByRoomsAmount form = new StatisticByRoomsAmount(conn);
                form.Show();
            };

            statisticLayout.Controls.Clear();
            statisticLayout.Controls.AddRange(new Control[] {
                statByDate,
                statByDistrict,
                statByRoomsAmount
            });
        }

        private void resizeStatisticPage()
        {
            if (Size.Width < 800)
            {

                statisticLayout.MaximumSize = new Size(Width - 70, default);

                if (employeeShowStatementWrapper.Location.X == 10) return;
                statisticWrapper.Location = new Point(10, statisticWrapper.Location.Y);

                return;
            }


            statisticLayout.MaximumSize = new Size(Width / 2 + Width / 4, default);


            statisticWrapper.Location = new Point(Size.Width / 2 - statisticWrapper.Width / 2, statisticWrapper.Location.Y);
        }
    }
}
