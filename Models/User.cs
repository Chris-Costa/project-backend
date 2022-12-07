namespace project_backend.Models;

public class User
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? Email { get; set; }
    public string? AzureId { get; set; }
    //public string? Username { get; set; }
    public string? Avatar { get; set; }
    public int WeightGoal { get; set; }
    public ICollection<Workout> Workout { get; set; }= new List<Workout>();
}