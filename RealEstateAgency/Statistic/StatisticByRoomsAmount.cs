using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateAgency.Models.db;
using System.Windows.Forms.DataVisualization.Charting;

namespace RealEstateAgency.Statistic
{
    public partial class StatisticByRoomsAmount : Form
    {
        public StatisticByRoomsAmount(RealEstateAgencyContext conn)
        {
            InitializeComponent();

            chart1.Series.Clear();
            chart1.Legends.Clear();

            var series = new Series("Кількість угод по кількості кімнат");

            var groupedDeals = conn.Deal
                                    .Join(conn.Show, deal => deal.IdShow, show => show.IdShow, (deal, show) => new { deal, show })
                                    .Join(conn.RealEstateObject, t1 => t1.show.IdObject, t2 => t2.IdObject, (deal, obj) => new { deal, obj })
                                    .GroupBy(el => el.obj.RoomsAmount)
                                    .Select(el => new { amount = el.Key, DealCount = el.Count() })
                                    .ToList();

            foreach (var deal in groupedDeals)
            {
                series.Points.AddXY($"{deal.amount}-кімнатні { deal.DealCount}", deal.DealCount);
            }

            chart1.Series.Add(series);

            series.ChartType = SeriesChartType.Pie;

            chart1.Legends.Add(new Legend("Legend1"));
            chart1.Series["Кількість угод по кількості кімнат"].Legend = "Legend1";
            chart1.Series["Кількість угод по кількості кімнат"].IsVisibleInLegend = true;
        }
    }
}
