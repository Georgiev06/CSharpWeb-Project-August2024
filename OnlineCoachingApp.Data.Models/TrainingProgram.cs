using System.ComponentModel.DataAnnotations;
using static OnlineCoachingApp.Common.EntityValidationsConstants.TrainingProgram;

namespace OnlineCoachingApp.Data.Models
{
    public class TrainingProgram
    {
        public TrainingProgram()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(DurationInWeeksMinLength, DurationInWeeksMaxLength)]
        public int DurationInWeeks { get; set; }

        [Required]
        [Range(PriceMinValue, PriceMaxValue)]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual Category Category { get; set; } = null!;

        public Guid CoachId { get; set; }

        public virtual Coach Coach { get; set; } = null!;

        public Guid UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}