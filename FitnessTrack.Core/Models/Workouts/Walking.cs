using FitnessTrack.Common.Types;
using FitnessTrack.Core.Abstractions;
using FitnessTrack.Core.Abstractions.WorkoutAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Models.Workouts
{
    public class Walking : IWorkout, IDistanceWorkout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateUpdated { get; set; }
        public int Duration { get; set; }
        public Distance Distance { get; set; }
        public int Steps { get; set; }
        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }
    }
}
