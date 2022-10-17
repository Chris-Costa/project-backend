namespace project_backend.Models;

public class Lift
{
    public int WorkoutID { get; set; }
    public string? Name { get; set; }
    public int Weight { get; set; }  //int|string
    public int? Sets { get; set; }
    public int? Reps { get; set; }
}   