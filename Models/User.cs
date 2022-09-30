namespace project_backend.Models;

public class User
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? Username { get; set; }
    public string? Avatar { get; set; }
    public int WeightGoal { get; set; }
    public int[]? LikedPosts { get; set; }
    public Workout[]? Workouts { get; set; }
}
public class Workout
{
    public string? Title { get; set; }
    public Lifts[]? Lifts { get; set; }
}
public class Lifts
{
    public string? Name { get; set; }
    public int Weight { get; set; }  //int|string
    public int? Sets { get; set; }
    public int? Reps { get; set; }
}   