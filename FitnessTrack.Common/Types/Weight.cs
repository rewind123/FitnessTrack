using FitnessTrack.Common.Abstractions;
using FitnessTrack.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Common.Types
{
    public record Weight : IMeasurementConvertible<Weight>
    {
        public Weight(double value, MeasurementSystem system)
        {
            Value = value;
            MeasurementSystem = system;
        }

        private Weight() { }

        
        public double Value { get; init; }
        public MeasurementSystem MeasurementSystem{ get; init;} 

        public Weight MetricToImperial()
        {
            if (MeasurementSystem == MeasurementSystem.Imperial) return this;

            return new Weight(Value * 2.2046, MeasurementSystem.Imperial);
        }

        public Weight ImperialToMetric()
        {
            if (MeasurementSystem == MeasurementSystem.Metric) return this;

            return new Weight(Value * 0.454, MeasurementSystem.Metric);
        }
    }
}
