namespace project_backend.Models;

public class Workout
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public List<Lift> Lifts { get; } = new();
}