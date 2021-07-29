using FitnessTrack.Common.Types;
using FitnessTrack.Core.Enums;
using FitnessTrack.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Abstractions
{
    public interface IUserProfile
    {
        int Id { get; set; }
        Uri ProfilePhotoUrl { get; set; }
        ProfileLocation Location { get; set; }
        ProfileSettings ProfileSettings { get; set; }
        DateTimeOffset DateOfBirth { get; set; }
        Gender Gender { get; set; }
        Height Height { get; set; }
        Weight Weight { get; set; }
        User User { get; set; }
    }
}
