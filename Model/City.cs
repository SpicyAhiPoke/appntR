using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointr.Model
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public DateTime CreateDate { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime LastUpdate { get; private set; }
        public string LastUpdateBy { get; private set; }

        public City() : this(0, string.Empty, 0, DateTime.Now, String.Empty, DateTime.Now, String.Empty) { }

        public City(int cityId, string city, int countryId, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CityId = cityId;
            CityName = city;
            CountryId = countryId;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;

        }

    }
}
