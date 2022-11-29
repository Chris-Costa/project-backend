using System.ComponentModel.DataAnnotations;

namespace project_backend.Models
{
    public class WorkoutCreation
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string? Title { get; set; } = string.Empty;
    }
}