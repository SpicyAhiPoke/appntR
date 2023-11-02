using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointr.Model
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public DateTime CreateDate { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime LastUpdate { get; private set; }
        public string LastUpdateBy { get; private set; }

        public Country() : this(0, string.Empty, DateTime.Now, String.Empty, DateTime.Now, String.Empty) { }
        public Country(int countryId, string country, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CountryId = countryId;
            CountryName = country;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;

        }

    }
}
