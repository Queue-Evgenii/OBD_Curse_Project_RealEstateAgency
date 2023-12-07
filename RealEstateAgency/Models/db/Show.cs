using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class Show
    {
        public Show()
        {
            Deal = new HashSet<Deal>();
        }

        public int IdObject { get; set; }
        public int IdShow { get; set; }
        public int IdPerson { get; set; }
        public DateTime ShowDate { get; set; }
        public int? IdEmployee { get; set; }

        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual RealEstateObject IdObjectNavigation { get; set; }
        public virtual Person IdPersonNavigation { get; set; }
        public virtual ICollection<Deal> Deal { get; set; }
    }
}
