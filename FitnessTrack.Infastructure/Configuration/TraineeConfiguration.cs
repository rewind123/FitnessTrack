using FitnessTrack.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Infastructure.Configuration
{
    public class TraineeConfiguration : IEntityTypeConfiguration<Trainee>
    {
        public void Configure(EntityTypeBuilder<Trainee> builder)
        {
            builder.OwnsOne(a => a.Location);
            builder.OwnsOne(a => a.ProfileSettings);
            builder.OwnsOne(a => a.Height);
            builder.OwnsOne(a => a.Weight);
        }
    }
}
