namespace project_backend.Models;

public class Comment
{
    public Guid Id { get; set; }
    public string User { get; set; }
    public string Reply { get; set; }
}