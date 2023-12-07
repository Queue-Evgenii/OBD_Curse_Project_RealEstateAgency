using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class Deal
    {
        public DateTime DateDeal { get; set; }
        public int IdShow { get; set; }
        public int IdDeal { get; set; }

        public virtual Show IdShowNavigation { get; set; }
    }
}
