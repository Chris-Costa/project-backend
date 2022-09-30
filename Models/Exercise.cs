namespace project_backend.Models;

public class Exercise
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? MuscleGroup { get; set; }
    public string? Description { get; set; }
    public string? RepRange { get; set; }
    public string? Difficulty { get; set; }
    public string? ImageURL { get; set; }
    public string? VideoURL { get; set; }
}