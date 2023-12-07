using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class Person
    {
        public Person()
        {
            Employee = new HashSet<Employee>();
            RealEstateObject = new HashSet<RealEstateObject>();
            Show = new HashSet<Show>();
        }

        public int IdPerson { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string AddressPerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual Passwords Passwords { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<RealEstateObject> RealEstateObject { get; set; }
        public virtual ICollection<Show> Show { get; set; }
    }
}
