using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using project_backend.Models;

namespace project_backend.Entities
{
    public class Exercise 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //generate new key when blog post is added
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? MuscleGroup { get; set; }
        public string? Description { get; set; }
        public string? RepRange { get; set; }
        public string? Difficulty { get; set; }
        public string? ImageURL { get; set; }
        public string? VideoURL { get; set; }
    }
}