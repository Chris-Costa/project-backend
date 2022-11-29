using System.ComponentModel.DataAnnotations;

namespace project_backend.Models
{
    public class ContactUsCreation
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string? Firstname { get; set; }

        [MaxLength(50)]
        public string? Lastname { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        [MaxLength(250)]
        public string? Notes { get; set; }
    }
}