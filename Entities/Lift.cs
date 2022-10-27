using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_backend.Entities
{
    public class Lift 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //generate new key when blog post is added
        public Guid Id { get; set; }
        public int WorkoutID { get; set; }
        public string? Name { get; set; }
        public int Weight { get; set; }  //int|string
        public int? Sets { get; set; }
        public int? Reps { get; set; } 
    }
}