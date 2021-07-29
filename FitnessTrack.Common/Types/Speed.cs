using FitnessTrack.Common.Abstractions;
using FitnessTrack.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Common.Types
{
    public class Speed : IMeasurementConvertible<Speed>
    {

        public Speed(double value, MeasurementSystem system)
        {
            Value = value;
            MeasurementSystem = system;
        }

        private Speed() { }
        public double Value { get; set; }
        
        public MeasurementSystem MeasurementSystem { get; set; }

        public Speed ImperialToMetric()
        {
            if (MeasurementSystem == MeasurementSystem.Metric) return this;

            return new Speed(Value * 1.609344, MeasurementSystem.Metric);
        }

        public Speed MetricToImperial()
        {
            if(MeasurementSystem == MeasurementSystem.Imperial) return this;

            return new Speed(Value * 0.6213711922, MeasurementSystem.Imperial);
        }
    }
}
