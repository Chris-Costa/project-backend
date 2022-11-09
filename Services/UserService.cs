using project_backend.Entities;
using project_backend.Data;
using Microsoft.EntityFrameworkCore;

namespace project_backend.Services
{
    public class UserService : IUserService
    {
        /*
        private readonly CVFitContext _context;

        public UserService(CVFitContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.OrderBy(u => u.Firstname).ToListAsync();
        }

        public async Task<User?> GetUserByID(int userId)
        {
            return await _context.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }

        public async Task<bool> UserExists(int userId)
        {
            return await _context.Users.AnyAsync(u => u.Id => userId);
        }

        public async Task CreateNewUser(User user)
        {
            _context.Users.Add(user);
        }

        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
        }

        //start of methods to deal with workouts
        public async Task<Workout?> GetWorkoutByID(int workoutId)
        {
            return await _context.Workout.Where(w => w.Id == workoutId).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Workout>> GetAllofUsersWorkouts(int userId)
        {
            return await _context.Users.Where(u => u.Id == userId).ToListAsync();
        }

        public async Task<Workout?> GetSpecificUserWorkout(int userId, int workoutId)
        {
            return await _context.Users.Where(u => u.Id == userId && u.Id == commentId).FirstOrDefaultAsync();
        }

        public async Task PostWorkoutToUser(int userId, Workout workout)
        {
            var user = await GetUserByID(userId);

            user.Users.Add(workout);
        }

        public void DeleteWorkout(Workout workout)
        {
            _context.Workout.Remove(workout);
        }

        //methods for lifts which are inside the workouts
        public async Task<bool> WorkoutExists(int workoutId)
        {
            return await _context.Workout.AnyAsync(w => w.Id == workoutId);
        }

        public async Task<IEnumerable<Lift>> GerAllLiftsOfWorkout(int workoutId)
        {
            return await _context.Workout.Where(l => l.WorkoutId == workoutId).ToListAsync();
        }

        public async Task<Lift?> GetSpecificLiftInWorkout(int workoutId, int liftId)
        {
            return await _context.Workout.Where(l => l.WorkoutId == workoutId && l.Id == liftId);
        }

        public async Task PostLiftToWorkout(int workouId, Lift lift)
        {
            var workout = await GetWorkoutByID(wokroutId);

            workout.Lift.Add(lift);
        }

        public void DeleteLift(Lift lift)
        {
            _context.Lift.Remove(lift);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
        */
    }
}