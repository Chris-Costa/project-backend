
using System.ComponentModel.DataAnnotations;

namespace project_backend.Models
{
    public class CommentCreation
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string User { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Reply { get; set; }
    }
}