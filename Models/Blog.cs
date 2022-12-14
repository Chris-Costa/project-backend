namespace project_backend.Models;

public class Blog
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Content { get; set; }
    public string? Avatar { get; set; }
    public int? Category { get; set; }
    public ICollection<Comment?> Comment { get; set; }= new List<Comment>();
}