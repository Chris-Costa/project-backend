using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using project_backend.Models;

namespace project_backend.Entities
{
    public class Workout 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //generate new key when blog post is added
        public Guid Id { get; set; }
        //public int UserID { get; set; }
        public string? Title { get; set; }
        public List<Lift> Lifts { get; } = new();
    }
}