using FitnessTrack.Core.Abstractions;
using FitnessTrack.Core.Abstractions.Repositories;
using FitnessTrack.Core.Models;
using FitnessTrack.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Infastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private FitnessTrackDbContext _ctx;
        public UserRepository(FitnessTrackDbContext ctx)
        {
            _ctx = ctx;
        }

        
        public async Task<User> UpdateUserAsync(User updatedUser)
        {
            try
            {
                _ctx.Users.Update(updatedUser);
                await _ctx.SaveChangesAsync();
                return updatedUser;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
