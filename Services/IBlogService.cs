using project_backend.Entities;

namespace project_backend.Services
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetBlogs();

        Task<Blog?> GetBlogByID(int blogId);
    }
}