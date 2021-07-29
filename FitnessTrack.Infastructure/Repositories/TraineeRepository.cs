using FitnessTrack.Common.Types;
using FitnessTrack.Core.Abstractions.Repositories;
using FitnessTrack.Core.Enums;
using FitnessTrack.Core.Models;
using FitnessTrack.Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Infastructure.Repositories
{
    public class TraineeRepository : ITraineeRepository
    {
        private readonly FitnessTrackDbContext _ctx;
        public TraineeRepository(FitnessTrackDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Trainee> CreateTraineeAsync(Trainee trainee)
        {
            try
            {
                if (trainee == null)
                    throw new ArgumentNullException("Trainee cannot be null");
                _ctx.Trainees.Add(trainee);
                await _ctx.SaveChangesAsync();
                return trainee;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public async Task<Trainee> DeleteTraineeAsync(int traineeId)
        {
            try
            {
                var trainee = await _ctx.Trainees.FirstOrDefaultAsync(tr => tr.Id == traineeId);
                if (trainee == null)
                    throw new ArgumentException($"No trainee with ID {traineeId} found in the database");

                _ctx.Trainees.Remove(trainee);
                await _ctx.SaveChangesAsync();
                return trainee;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Trainee> UpdateBasicInfoAsync(int traineeId, Gender gender, Uri profilePhoto = null, DateTimeOffset dateOfBirth = default, Height height = null, Weight weight = null)
        {
            try
            {
                var trainee = await _ctx.Trainees.FirstOrDefaultAsync(t => t.Id == traineeId);
                if (trainee == null)
                    throw new ArgumentException($"No trainee with ID {traineeId} found in the database");

                trainee.Gender = gender;

                if (profilePhoto != null)
                    trainee.ProfilePhotoUrl = profilePhoto;

                if (dateOfBirth == default(DateTimeOffset))
                    trainee.DateOfBirth = dateOfBirth;

                if (height != null)
                    trainee.Height = height;

                if (weight != null)
                    trainee.Weight = weight;

                _ctx.Trainees.Update(trainee);
                await _ctx.SaveChangesAsync();
                return trainee;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Trainee> UpdateProfileLocationAsync(int traineeId, ProfileLocation location)
        {
            throw new NotImplementedException();
        }

        public Task<Trainee> UpdateProfileSettingsAsync(int traineeId, ProfileSettings settings)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
