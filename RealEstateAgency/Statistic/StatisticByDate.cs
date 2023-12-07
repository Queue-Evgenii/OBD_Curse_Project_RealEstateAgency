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

namespace RealEstateAgency.Statistic
{
    public partial class StatisticByDate : Form
    { 

        public StatisticByDate(RealEstateAgencyContext conn)
        {
            InitializeComponent();

            if (conn == null) Close();


            DateTime endDate = DateTime.Now;
            DateTime startDate = DateTime.Now;

            startDate = endDate.AddDays(-14);

            chart.Series.Clear();
            chart.Series.Add("Угоди");

            var dealsByDay = conn.Deal
                .Where(el => el.DateDeal >= startDate && el.DateDeal <= endDate)
                .GroupBy(el => el.DateDeal)
                .Select(el => new
                {
                    Date = el.Key,
                    DealCount = el.Count()
                });


            foreach (var dealInfo in dealsByDay)
            {
                chart.Series["Угоди"].Points.AddXY(dealInfo.Date, dealInfo.DealCount);
            }
        }
    }
}
