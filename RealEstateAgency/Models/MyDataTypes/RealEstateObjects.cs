using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateAgency.Models.db;

namespace RealEstateAgency.Models.MyDataTypes
{
    abstract class RealEstateObjects
    {
        protected RealEstateAgencyContext _conn;

        protected List<RealEstateObject> _originalPublicationsList = null;
        protected List<District> _districts = null;


        protected RealEstateObjects(RealEstateAgencyContext conn)
        {
            _conn = conn;

            _originalPublicationsList = conn.RealEstateObject.ToList();

            loadFullObjectData();
        }

        protected void loadFullObjectData()
        {
            foreach (RealEstateObject item in _originalPublicationsList)
            {
                if (item.HouseBuilding != null) continue;
                _conn.Entry(item).Reference(t => t.HouseBuilding).Load();

                if (item.HouseBuilding.StreetNameNavigation != null) continue;
                _conn.Entry(item.HouseBuilding).Reference(t => t.StreetNameNavigation).Load();

            }
        }

        abstract public List<RealEstateObject> get();
    }
}
