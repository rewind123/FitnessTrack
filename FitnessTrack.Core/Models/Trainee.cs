using FitnessTrack.Common.Types;
using FitnessTrack.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Models
{
    public class Trainee : IUserprofile
    {
        public int Id { get; set; }
        public Uri ProfilePhotoUrl { get; set; }
        public ProfileLocation Location { get; set; }
        public ProfileSettings ProfileSettings { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Height Height { get; set; }
        public Weight Weight { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

    }

}
