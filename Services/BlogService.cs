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
            return await _context.Blogs.Include(b => b.Comment)
                    .Where(b => b.Id == blogId).FirstOrDefaultAsync();
            
        }
        /*
        public async Task<IEnumerable<Comment>> GetBlogsComments(int blogId)
        {
            return await _context.Comments.Where(c => c.BlogId == blogId).ToListAsync();
        }

        public async Task<Comment?> GetBlogsComments(int blogId, int commentId)
        {
            return await _context.Comments.Where(c => c.BlogId == blogId && c.Id == commentId).FirstOrDefaultAsync();
        }
        */
    }
}