using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateAgency.Models.db;

namespace RealEstateAgency.Models.MyDataTypes
{
    class MyPublicationsList : RealEstateObjects
    {
        private List<RealEstateObject> _myPublications = null;
        private List<ObjectStatus> _status = null;

        public MyPublicationsList(RealEstateAgencyContext conn, int userId) : base(conn)
        {
            _myPublications = _originalPublicationsList = conn.RealEstateObject.Where(el => el.IdPerson == userId).OrderByDescending(el => el.PublishDate).ToList();
            _status = conn.ObjectStatus.ToList();
        }

        public override List<RealEstateObject> get()
        {
            return _myPublications;
        }

        public List<ObjectStatus> status
        {
            get {
                return _status;
            }
        }
    }
}
