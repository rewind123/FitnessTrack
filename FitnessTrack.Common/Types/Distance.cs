using FitnessTrack.Common.Abstractions;
using FitnessTrack.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Common.Types
{
    public record Distance : IMeasurementConvertible<Distance>
    {

        public Distance(double value, MeasurementSystem system)
        {
            Value = value;
            MeasurementSystem = system;
        }

        private Distance() { }

        
        public double Value { get; init; }
        public MeasurementSystem MeasurementSystem { get; init; }

        public Distance MetricToImperial()
        {
            if (MeasurementSystem == MeasurementSystem.Imperial) return this;

            
            return new Distance(Value * 0.62, MeasurementSystem.Imperial);

        }

        public Distance ImperialToMetric()
        {
            if (MeasurementSystem == MeasurementSystem.Metric) return this;


            return new Distance(Value * 1.61, MeasurementSystem.Metric);

        }
    }
}
