using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Common.Abstractions
{
    public interface IMeasurementConvertible<T>
    {
        T MetricToImperial();
        T ImperialToMetric();
    }
}
