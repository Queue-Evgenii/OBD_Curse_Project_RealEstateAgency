using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class Employee
    {
        public Employee()
        {
            Show = new HashSet<Show>();
        }

        public int IdEmployee { get; set; }
        public int IdPerson { get; set; }
        public string NamePosition { get; set; }

        public virtual Person IdPersonNavigation { get; set; }
        public virtual Position NamePositionNavigation { get; set; }
        public virtual ICollection<Show> Show { get; set; }
    }
}
