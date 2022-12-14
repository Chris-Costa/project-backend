using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using project_backend.Models;

namespace project_backend.Entities
{
    public class Blog 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //generate new key when blog post is added
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Content { get; set; }
        public string? Avatar { get; set; }
        public int? Category { get; set; }
        public ICollection<Comment?> Comment { get; set; } = new List<Comment>();
    }
}