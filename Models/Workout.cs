namespace project_backend.Models;

public class Workout
{
    public int UserID { get; set; }
    public string? Title { get; set; }
    public List<Lift> Lifts { get; } = new();
}