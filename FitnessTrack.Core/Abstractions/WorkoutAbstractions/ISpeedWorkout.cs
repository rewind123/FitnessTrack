using FitnessTrack.Common.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Abstractions.WorkoutAbstractions
{
    public interface ISpeedWorkout
    {
        public Speed AverageSpeed { get; set; }
        public Speed MaxSpeed { get; set; }
    }
}
