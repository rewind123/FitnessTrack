using FitnessTrack.Common.Types;
using FitnessTrack.Core.Abstractions;
using FitnessTrack.Core.Abstractions.WorkoutAbstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Core.Models.Workouts
{
    public class Cycling : IWorkout, IDistanceWorkout, IElevationWorkout, ISpeedWorkout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateUpdated { get; set; }
        public Distance Distance { get; set; }
        public int Duration { get; set; }
        public Speed AverageSpeed { get; set; }
        public Speed MaxSpeed { get; set; }
        public Height ElevationGain { get; set; }
        public Height ElevationLoss { get; set; }
        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }
        
        public Height TotalElevation { get { return GetTotalElevation(); } private set { } }
        private Height GetTotalElevation()
        {
            return new Height(ElevationGain.Value + ElevationLoss.Value, ElevationGain.MeasurementSystem);
        }
    }
}
