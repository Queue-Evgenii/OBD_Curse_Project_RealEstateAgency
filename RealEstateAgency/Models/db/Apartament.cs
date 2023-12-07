using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class Apartament
    {
        public int IdObject { get; set; }
        public int? ApartFloor { get; set; }
        public string ApartService { get; set; }

        public virtual RealEstateObject IdObjectNavigation { get; set; }
    }
}
