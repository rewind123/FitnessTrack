using FitnessTrack.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Abstractions
{
    public interface IWorkout
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTimeOffset DateCreated { get; set; }
        DateTimeOffset DateUpdated { get; set; }
        int Duration { get; set; }
        int TraineeId { get; set; }
        Trainee Trainee { get; set; }
    }
}
