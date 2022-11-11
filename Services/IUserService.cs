using project_backend.Entities;

namespace project_backend.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();

        Task<User?> GetUserByID(int userId);

        Task<bool> UserExists(int userId);

        Task CreateUser(User user);

        void DeleteUser(User user);

        Task<Workout?> GetWorkoutByID(int workoutId);

        Task<IEnumerable<Workout>> GetAllofUsersWorkouts(int userId);

        Task<Workout?> GetSpecificUserWorkout(int userId, int workoutId);

        Task PostWorkoutToUser(int userId, Workout workout);

        void DeleteWorkout(Workout workout);

        Task<bool> WorkoutExists(int workoutId);

        Task<IEnumerable<Lift>> GetAllLiftsOfWorkout(int workoutId);

        Task<Lift?> GetSpecificWorkoutLift(int workoutId, int liftId);

        Task PostLiftToWorkout(int workouId, int exerciseId, Lift lift);

        void DeleteLift(Lift lift);

        Task<bool> SaveChangesAsync();

        //for contact us 
        Task<IEnumerable<ContactUs>> GetProspectiveClients();

        Task<ContactUs?> GetProspectiveClientById(int id);

        Task<bool> ProspectiveExists(int id);

        Task CreateProspectiveClient(ContactUs contactUs);

        void DeleteProspectiveClient(ContactUs contactUs);
    }
}