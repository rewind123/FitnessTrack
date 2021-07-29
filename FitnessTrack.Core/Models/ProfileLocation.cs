using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Models
{
    public record ProfileLocation
    {
        public ProfileLocation(string country, string region, string city)
        {
            Country = country;
            Region = region;
            City = city;
        }

        private ProfileLocation() { }

       
        string Country { get; set; }
        string Region { get; set; }
        string City { get; set; }
    }
}
