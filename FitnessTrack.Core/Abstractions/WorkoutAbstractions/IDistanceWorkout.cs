using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTrack.Common.Types;

namespace FitnessTrack.Core.Abstractions.WorkoutAbstractions
{
    public interface IDistanceWorkout
    {
        Distance Distance { get; set; }
    }
}
