using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class District
    {
        public District()
        {
            Street = new HashSet<Street>();
        }

        public string NameDistrict { get; set; }

        public virtual ICollection<Street> Street { get; set; }
    }
}
