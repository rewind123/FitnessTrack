using FitnessTrack.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Abstractions.Repositories
{
    public interface IUserRepository : IFitnessTrackRepository
    {
        Task<User> UpdateUserAsync(User updatedUser);
    }
}
