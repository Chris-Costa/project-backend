using project_backend.Entities;
using project_backend.Data;
using Microsoft.EntityFrameworkCore;

namespace project_backend.Services
{
    public class BlogService : IBlogService
    {
        private readonly CVFitContext _context;

        public BlogService(CVFitContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Blog>> GetBlogs()
        {
            return await _context.Blogs.OrderBy(b => b.Title).ToListAsync();
        }

        public async Task<Blog?> GetBlogByID(int blogId)
        {
            return await _context.Blogs.Include(b => b.Comment).Where(b => b.Id == blogId).FirstOrDefaultAsync();
        }

        public async Task<bool> BlogExists(int blogId)
        {
            return await _context.Blogs.AnyAsync(b => b.Id == blogId);
        }

        public async Task CreateBlogPost(Blog blog)
        {
            _context.Blogs.Add(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            _context.Blogs.Remove(blog);
        }

        public async Task<IEnumerable<Comment>> GetAllBlogsComments(int blogId)
        {
            return await _context.Comment.Where(c => c.BlogId == blogId).ToListAsync();
        }

        public async Task<Comment?> GetSpecificBlogComment(int blogId, int commentId)
        {
            return await _context.Comment.Where(c => c.BlogId == blogId && c.Id == commentId).FirstOrDefaultAsync();
        }

        public async Task PostCommentToBlogPost(int blogId, Comment comment)
        {
            var blog = await GetBlogByID(blogId);
            
            blog.Comment.Add(comment);
        }

        public void DeleteComment(Comment comment)
        {
            _context.Comment.Remove(comment);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}