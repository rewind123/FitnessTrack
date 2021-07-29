using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Abstractions.Repositories
{
    public interface IWorkoutRepository<T> : IFitnessTrackRepository where T : IWorkout
    {
        Task<T> CreateWorkoutAsync(T workout);
        Task<T> UpdateWorkoutAsync(T updatedWorkout);
        Task<T> DeleteWorkoutAsync(int workoutId);
        Task<ICollection<T>> GetWorkoutsForTimeIntervalAsync(DateTimeOffset startTime, DateTimeOffset endTime);
        Task<ICollection<T>> GetTraineeAsync(int traineeId);
        Task<ICollection<T>> GetTraineeWorkoutsForTimeIntervalAsync(int traineeId, DateTimeOffset startTime, DateTimeOffset endTime);
    }
}
