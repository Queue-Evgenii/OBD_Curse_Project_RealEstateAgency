using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class ObjectStatus
    {
        public ObjectStatus()
        {
            RealEstateObject = new HashSet<RealEstateObject>();
        }

        public string StatusObject { get; set; }

        public virtual ICollection<RealEstateObject> RealEstateObject { get; set; }
    }
}
