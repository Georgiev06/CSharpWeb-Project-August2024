using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineCoachingApp.Common.EntityValidationsConstants.Coach;

namespace OnlineCoachingApp.Data.Models
{
    public class Coach
    {
        public Coach()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [MaxLength(BioMaxLength)]
        public string? Bio { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }

        public virtual User User { get; set; } = null!;

        public virtual ICollection<TrainingProgram> TrainingPrograms { get; set; } = new HashSet<TrainingProgram>();
    }
}
