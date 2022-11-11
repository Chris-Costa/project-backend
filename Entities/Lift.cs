using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_backend.Entities
{
    public class Lift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //generate new key when blog post is added
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Weight { get; set; } 
        public int? Sets { get; set; }
        public int? Reps { get; set; }

        [ForeignKey("WorkoutId")]
        public Workout? Workout { get; set; }
        public int WorkoutId { get; set; } 
    }
}