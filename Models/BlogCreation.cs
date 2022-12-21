using System.ComponentModel.DataAnnotations;

namespace project_backend.Models
{
    public class BlogCreation
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string? Title { get; set; }

        [MaxLength(50)]
        public string? Author { get; set; }

        [MaxLength(500)]
        public string? Content { get; set; }

        [MaxLength(50)]
        public string? Avatar { get; set; } = string.Empty;

        public int? Category { get; set; }
    }
}