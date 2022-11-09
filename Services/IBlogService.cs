using project_backend.Entities;

namespace project_backend.Services
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetBlogs();

        Task<Blog?> GetBlogByID(int blogId);

        Task<bool> BlogExists(int blogId);

        Task<IEnumerable<Comment>> GetAllBlogsComments(int blogId);

        Task<Comment?> GetSpecificBlogComment(int blogId, int commentId);

        Task PostCommentToBlogPost(int blogId, Comment comment);

        void DeleteComment(Comment comment);

        Task<bool> SaveChangesAsync();
    }
}