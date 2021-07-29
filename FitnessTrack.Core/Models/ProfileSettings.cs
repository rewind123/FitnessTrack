using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTrack.Common.Enums;

namespace FitnessTrack.Core.Models
{
    public record ProfileSettings
    {

        public ProfileSettings(string timezone, MeasurementSystem system)
        {
            TimeZone = timezone;
            PreferredMeasurementSystem = system;
        }

        private ProfileSettings() { }

        
        public string TimeZone { get; init; }
        public MeasurementSystem PreferredMeasurementSystem { get; init; }

    }
}
