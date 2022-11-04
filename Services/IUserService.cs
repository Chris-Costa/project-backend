using project_backend.Entities;

namespace project_backend.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();

        Task<User?> GetUserByID(int userId);
    }
}