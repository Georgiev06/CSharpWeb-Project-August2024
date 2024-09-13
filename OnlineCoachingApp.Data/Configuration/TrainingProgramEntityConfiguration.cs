using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineCoachingApp.Data.Models;

namespace OnlineCoachingApp.Data.Configuration
{
    public class TrainingProgramEntityConfiguration : IEntityTypeConfiguration<TrainingProgram>
    {
        public void Configure(EntityTypeBuilder<TrainingProgram> builder)
        {
            builder
                .Property(tp => tp.CreatedOn)
                .HasDefaultValue(DateTime.UtcNow);

            builder
                .HasOne(tp => tp.Category)
                .WithMany(c => c.TrainingPrograms)
                .HasForeignKey(tp => tp.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(tp => tp.Coach)
                .WithMany(c => c.TrainingPrograms)
                .HasForeignKey(tp => tp.CoachId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(this.SeedTrainingPrograms());
        }

        private TrainingProgram[] SeedTrainingPrograms()
        {
            ICollection<TrainingProgram> trainingPrograms = new HashSet<TrainingProgram>();

            TrainingProgram trainingProgram;

            trainingProgram = new TrainingProgram()
            {
                Name = "Fitness Program",
                Description = "A comprehensive strength training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.",
                ImageUrl = "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/b9205c59-f0ed-438f-ab45-3f29f957282d/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_2.jpg",
                DurationInWeeks = 4,
                Price = 39.99m,
                CategoryId = 2,
                CoachId = Guid.Parse("D857D2EB-3AA9-42B8-8E29-0D939D36D12C"),
                UserId = Guid.Parse("84899585-883B-4378-A5FD-C1AC78DD7867")
            };

            trainingPrograms.Add(trainingProgram);

            trainingProgram = new TrainingProgram()
            {
                Name = "Fitness Program",
                Description = "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.",
                ImageUrl = "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512",
                DurationInWeeks = 4,
                Price = 49.99m,
                CategoryId = 2,
                CoachId = Guid.Parse("D857D2EB-3AA9-42B8-8E29-0D939D36D12C"),
                UserId = Guid.Parse("C85CA7CF-4F7D-4239-528C-08DCBEAC59AB")
            };

            trainingPrograms.Add(trainingProgram);

            return trainingPrograms.ToArray();
        }
    }
}
