using project_backend.Entities;
using project_backend.Data;
using Microsoft.EntityFrameworkCore;

namespace project_backend.Services
{
    public class UserService : IUserService
    {
        private readonly CVFitContext _context;

        public UserService(CVFitContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            //order by used for name currently maybe category later
            return await _context.Users.OrderBy(u => u.Firstname).ToListAsync();
        }

        public async Task<User?> GetUserByID(int userId)
        {
            return await _context.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }
    }
}