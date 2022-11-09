namespace project_backend.Models;

public class Workout
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public ICollection<Lift> Lift { get; set; }
            = new List<Lift>();
}