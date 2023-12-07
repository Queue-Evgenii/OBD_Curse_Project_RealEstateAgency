using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class RealEstateObject
    {
        public RealEstateObject()
        {
            Photo = new HashSet<Photo>();
            Show = new HashSet<Show>();
        }

        public RealEstateObject(RealEstateObject obj)
        {
            Photo = new HashSet<Photo>();
            Show = new HashSet<Show>();
        }

        public int IdObject { get; set; }
        public int? Price { get; set; }
        public DateTime? PublishDate { get; set; }
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public int IdPerson { get; set; }
        public int? ObjectFloorsAmount { get; set; }
        public int? Footage { get; set; }
        public int? RoomsAmount { get; set; }
        public string StatusObject { get; set; }
        public string ObjectDescription { get; set; }

        public virtual HouseBuilding HouseBuilding { get; set; }
        public virtual Person IdPersonNavigation { get; set; }
        public virtual ObjectStatus StatusObjectNavigation { get; set; }
        public virtual Apartament Apartament { get; set; }
        public virtual House House { get; set; }
        public virtual ICollection<Photo> Photo { get; set; }
        public virtual ICollection<Show> Show { get; set; }
    }
}
