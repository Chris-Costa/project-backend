using project_backend.Models;

namespace project_backend.Services;

public static class BlogService
{
    static List<Blog> Blogs { get; }
    static int nextId = 3;
    static BlogService()
    {
        Blogs = new List<Blog>
        {
            new Blog { Id = 1, Title = "Test 1", Author = "Author 1",  Content = "Some Content 1", Avatar = "", Likes = 10, Comments = {user = "User 1", Reply = "Some reply 1"} },
            new Blog { Id = 2, Title = "Test 2", Author = "Author 2", Content = "Some Content 2", Avatar = "", Likes = 5, Comments = {user = "User 2", Reply = "Some reply 2"} }
        };
    }

    public static List<Blog> GetAll() => Blogs;
    

    public static Blog? Get(int id) => Blogs.FirstOrDefault(b => b.Id == id);

    public static void Add(Blog blog)
    {
        blog.Id = nextId++;
        Blogs.Add(blog);
    }

    public static void Delete(int id)
    {
        var blog = Get(id);
        if(blog is null)
            return;

        Blogs.Remove(blog);
    }

    public static void Update(Blog blog)
    {
        var index = Blogs.FindIndex(b => b.Id == blog.Id);
        if(index == -1)
            return;

        Blogs[index] = blog;
    }
}