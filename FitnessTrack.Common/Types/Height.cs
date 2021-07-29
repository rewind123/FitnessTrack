using FitnessTrack.Common.Abstractions;
using FitnessTrack.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Common.Types
{
    public record Height : IMeasurementConvertible<Height>
    {
        public Height(double value, MeasurementSystem system)
        {
            Value = value;
            MeasurementSystem = system;
        }

        private Height() { }

       
        public double Value { get; init; }
        public MeasurementSystem MeasurementSystem { get; init; }

        public Height MetricToImperial()
        {
            if (MeasurementSystem == MeasurementSystem.Imperial) return this;

            var ToMeters = Value * 100;
            return new Height(ToMeters * 3.28, MeasurementSystem.Imperial);

        }

        public Height ImperialToMetric()
        {
            if (MeasurementSystem == MeasurementSystem.Metric) return this;

            var ToCentimeters = (Value * .30) / 100;
            return new Height(ToCentimeters, MeasurementSystem.Metric);

        }
    }
}
