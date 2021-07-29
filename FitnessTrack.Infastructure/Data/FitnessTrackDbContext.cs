using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using FitnessTrack.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FitnessTrack.Core.Models.Workouts;
using FitnessTrack.Infastructure.Configuration;

namespace FitnessTrack.Infastructure.Data
{
    public class FitnessTrackDbContext : IdentityDbContext<User, Role, string>
    {
        public FitnessTrackDbContext(DbContextOptions<FitnessTrackDbContext> options) : base(options) {  }
        public new DbSet<User> Users { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Cycling> CyclingWorkouts { get; set; }
        public DbSet<Walking> WalkingWorkouts { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TraineeConfiguration());
            builder.ApplyConfiguration(new CyclingConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new WalkingConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
