using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class Street
    {
        public Street()
        {
            HouseBuilding = new HashSet<HouseBuilding>();
        }

        public string StreetName { get; set; }
        public string NameDistrict { get; set; }

        public virtual District NameDistrictNavigation { get; set; }
        public virtual ICollection<HouseBuilding> HouseBuilding { get; set; }
    }
}
