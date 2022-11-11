using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using project_backend.Models;

namespace project_backend.Entities
{
    public class Workout 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //generate new key when blog post is added
        public int Id { get; set; }
        public string? Title { get; set; }
        public ICollection<Lift> Lift { get; set; } = new List<Lift>();

        [ForeignKey("UserId")]
        public User? User { get; set; }
        public int UserId { get; set; }
    }
}