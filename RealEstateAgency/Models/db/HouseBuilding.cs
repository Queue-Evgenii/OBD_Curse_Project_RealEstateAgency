using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class HouseBuilding
    {
        public HouseBuilding()
        {
            RealEstateObject = new HashSet<RealEstateObject>();
        }

        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public int? BuildingFloorsAmount { get; set; }
        public int? BuildingYear { get; set; }
        public string WallMaterial { get; set; }

        public virtual Street StreetNameNavigation { get; set; }
        public virtual ICollection<RealEstateObject> RealEstateObject { get; set; }
    }
}
