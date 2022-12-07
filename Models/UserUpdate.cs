using System.ComponentModel.DataAnnotations;

namespace project_backend.Models
{
    public class UserUpdate
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string? Firstname { get; set; }

        [MaxLength(50)]
        public string? Lastname { get; set; }

        [MaxLength(50)]
        //public string? Username { get; set; }
        public string? Email { get; set; }

        [MaxLength(50)]
        public string? AzureId { get; set; }

        [MaxLength(50)]
        public string? Avatar { get; set; } = string.Empty;

        public int WeightGoal { get; set; }
    }
}