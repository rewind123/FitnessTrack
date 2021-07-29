using FitnessTrack.Common.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Abstractions.WorkoutAbstractions
{
    public interface IElevationWorkout
    {
        public Height ElevationGain { get; set; }
        public Height ElevationLoss { get; set; }

        public Height TotalElevation { get; }
    }
}
