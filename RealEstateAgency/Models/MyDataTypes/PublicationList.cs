using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateAgency.Models.db;

namespace RealEstateAgency.Models.MyDataTypes
{
    enum Sort
    {
        None = 0,
        PriceDesc = 1,
        PriceAsc = 2,
        DateAsc = 3,
        DateDesc = 4,
    }
    class PublicationList : RealEstateObjects
    {
        private List<RealEstateObject> _publicationsList = null;

        private List<Street> _streets = null;
        private int?[] _roomsInList = null;

        private Sort _sort = Sort.None;
        private int? _rooms = null;
        private string _district = "не обрано";
        private string _street = "не обрано";
        private int? _min = 0;
        private int? _max = int.MaxValue;

        public PublicationList(RealEstateAgencyContext conn) : base(conn)
        {
            _publicationsList = _originalPublicationsList.ToList();

            _districts = conn.District.ToList();
            _roomsInList = _originalPublicationsList.Select(el => el.RoomsAmount).Distinct().ToArray();
        }

        /// <summary>
        /// Getter for list of publications
        /// </summary>
        /// <returns>Return list of publications. Data type is List<RealEstateObject></returns>
        override public List<RealEstateObject> get() 
        {
            return _publicationsList.Where(el => el.StatusObject == "у продажу").ToList();
        }


        /* ================ Getters and Setters =============== */
        public Sort sort {
            set {
                _sort = value;

                applyFilters();
            }
        }
        public string district
        {
            set
            {
                _district = value;

                applyFilters();
            }
        }
        public string street
        {
            set
            {
                _street = value;

                applyFilters();
            }
        }
        public int? rooms
        {
            set
            {
                _rooms = value;

                applyFilters();
            }
        }
        public int? min
        {
            set
            {
                _min = value;
            }
        }
        public int? max
        {
            set
            {
                _max = value;
            }
        }

        public List<District> districts
        {
            get
            {
                return _districts;
            }
        }
        public List<Street> streets
        {
            get
            {
                return _streets;
            }
        }
        public int?[] roomsInList
        {
            get
            {
                return _roomsInList;
            }
        }


        private void applyFilters()
        {
            _publicationsList = _originalPublicationsList.ToList();

            applyAddress();
            applyPrice();
            applyRooms();
            applySort();
        }
        private void applyAddress()
        {
            if (_district == null) return;

            if (!(_districts.Where(el => el.NameDistrict == _district).Any())) return;

            _publicationsList = _publicationsList
                                    .Where(el => el.HouseBuilding.StreetNameNavigation.NameDistrict == _district)
                                    .ToList();


            if (_street == null) return;

            _streets = _conn.Street.Where(el => el.NameDistrict == _district).ToList();

            if (!(_streets.Where(el => el.StreetName == _street).Any())) return;

            _publicationsList = _publicationsList
                                    .Where(el => el.HouseBuilding.StreetName == _street)
                                    .ToList();
        }
        private void applyRooms()
        {
            if (_rooms == null) return;

            _publicationsList = _publicationsList.Where(el => el.RoomsAmount == _rooms).ToList();
        }
        private void applySort()
        {
            switch (_sort)
            {
                case Sort.None:
                    break;
                case Sort.PriceAsc:
                    _publicationsList = _publicationsList.OrderBy(el => el.Price).ToList();
                    break;
                case Sort.PriceDesc:
                    _publicationsList = _publicationsList.OrderByDescending(el => el.Price).ToList();
                    break;
                case Sort.DateAsc:
                    _publicationsList = _publicationsList.OrderBy(el => el.PublishDate).ToList();
                    break;
                case Sort.DateDesc:
                    _publicationsList = _publicationsList.OrderByDescending(el => el.PublishDate).ToList();
                    break;
                default:
                    break;
            }
        }
        private void applyPrice()
        {
            _publicationsList = _publicationsList.Where(el => el.Price >= _min && el.Price <= _max).ToList();
        }

        /// <summary>
        /// Method that call filters applying with price filtration
        /// </summary>
        /// <exception cref="Exception">when min value greater then max.</exception>

        public void applyPriceFilter()
        {
            if (_min > _max) throw new Exception("Incorrect data! Min value can`t be greater then max");

            applyFilters();
        }
        public void clearFilters()
        {
            _publicationsList = _originalPublicationsList.ToList();
        }
    }
}
