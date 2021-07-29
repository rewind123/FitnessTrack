using FitnessTrack.Core.Models.Workouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Abstractions.Repositories
{
    public interface ICyclingRepository : IWorkoutRepository<Cycling>, IFitnessTrackRepository
    {
      
    }
}
