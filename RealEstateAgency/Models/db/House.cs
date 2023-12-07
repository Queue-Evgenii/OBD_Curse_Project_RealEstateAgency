using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class House
    {
        public int IdObject { get; set; }
        public int? YardFootage { get; set; }
        public string GarageDescription { get; set; }
        public string HouseLoft { get; set; }

        public virtual RealEstateObject IdObjectNavigation { get; set; }
    }
}
