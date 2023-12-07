using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RealEstateAgency.Models.db;

namespace RealEstateAgency.Statistic
{
    public partial class GeneralShowStatistic : Form
    {
        public GeneralShowStatistic(RealEstateAgencyContext conn, List<RealEstateObject> obj)
        {
            InitializeComponent();
            Chart chart1 = new Chart();

            chart1.Width = Width - 50;
            chart1.Height = Height - 50;
            chart1.Location = new Point(20, 5);

            int max = 0;
            chart1.Series.Add("Перегляди");
            for (int i = 0; i < obj.Count; ++i)
            {
                int count = conn.Show.Where(el => el.IdObject == obj[i].IdObject).Count();
                if (count > max) max = count;
                chart1.Series["Перегляди"].Points.AddXY(obj[i].StreetName + obj[i].HouseNumber + obj[i].Price, count);
            }


            chart1.ChartAreas.Add("Перегляди");
            chart1.ChartAreas[0].AxisY.Maximum = max + 10;

            // Добавление легенды
            chart1.Legends.Add(new Legend("Легенда"));
            chart1.Series["Перегляди"].Legend = "Легенда";

            Controls.Add(chart1);
        }
    }
}
