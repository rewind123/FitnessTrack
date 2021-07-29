using FitnessTrack.Common.Types;
using FitnessTrack.Core.Enums;
using FitnessTrack.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Abstractions.Repositories
{
    public interface ITraineeRepository : IFitnessTrackRepository
    {
        Task<Trainee> CreateTraineeAsync(Trainee trainee);
        Task<Trainee> UpdateProfileSettingsAsync(int traineeId, ProfileSettings settings);
        Task<Trainee> UpdateProfileLocationAsync(int traineeId, ProfileLocation location);
        Task<Trainee> UpdateBasicInfoAsync(int traineeId, Gender gender, Uri profilePhoto = null, DateTimeOffset dateOfBirth = default(DateTimeOffset), Height height = null, Weight weight = null);
        Task<Trainee> DeleteTraineeAsync(int traineeId);
    }
}
