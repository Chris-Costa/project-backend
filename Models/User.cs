namespace project_backend.Models;

public class User
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? Username { get; set; }
    public string? Avatar { get; set; }
    public int WeightGoal { get; set; }
    //public int[]? LikedPosts { get; set; }
    //public Workout[]? Workouts { get; set; }
}