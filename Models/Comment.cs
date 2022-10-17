namespace project_backend.Models;

public class Comment
{
    public int BlogID { get; set; }
    public string User { get; set; }
    public string Reply { get; set; }
}