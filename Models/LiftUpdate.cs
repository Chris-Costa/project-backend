using System.ComponentModel.DataAnnotations;

namespace project_backend.Models
{
    public class LiftUpdate
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string? Name { get; set; }

        public int? Weight { get; set; }

        public int? Sets { get; set; }

        public int? Reps { get; set; } 
    }
}