using project_backend.Entities;

namespace project_backend.Services
{
    public interface IUserService
    {
        //Task<bool> UserExists(int userId);

        Task<IEnumerable<Workout>> GetWorkouts();
        
        Task<Workout?> GetWorkoutByID(int workoutId);

        Task<IEnumerable<Workout>> GetAllofUsersWorkouts(string userId);

        Task<Workout?> GetSpecificUserWorkout(string userId, int workoutId);

        Task PostWorkoutToUser(Workout workout);

        void DeleteWorkout(Workout workout);

        Task<bool> WorkoutExists(int workoutId);

        Task<IEnumerable<Lift>> GetAllLiftsOfWorkout(int workoutId);

        Task<Lift?> GetLiftByID(int liftId);

        Task<Lift?> GetSpecificWorkoutLift(int workoutId, int liftId);

        Task PostLiftToWorkout(int workoutId, Lift lift);

        Task<bool> LiftExists(int liftId);

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