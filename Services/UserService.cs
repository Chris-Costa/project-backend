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

        /*
        public async Task<bool> UserExists(int userId)
        {
            return await _context.Users.AnyAsync(u => u.Id == userId);
        }*/

        public async Task<IEnumerable<Workout>> GetWorkouts()
        {
            return await _context.Workout.Include(w => w.Lift).OrderBy(e => e.AzureId).ToListAsync();
        }
       
        public async Task<Workout?> GetWorkoutByID(int workoutId)
        {
            return await _context.Workout.Include(i => i.Lift).Where(w => w.Id == workoutId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Workout>> GetAllofUsersWorkouts(string userId)
        {
            return await _context.Workout.Include(w => w.Lift).Where(u => u.AzureId == userId).ToListAsync();
        }

        public async Task<Workout?> GetSpecificUserWorkout(string userId, int workoutId)
        {
            return await _context.Workout.Include(w => w.Lift).Where(u => u.AzureId == userId && u.Id == workoutId).FirstOrDefaultAsync();
        }

        public async Task PostWorkoutToUser(Workout workout)
        {
            _context.Workout.Add(workout);
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

        public async Task<IEnumerable<Lift>> GetAllLiftsOfWorkout(int workoutId)
        {
            return await _context.Lift.Where(l => l.WorkoutId == workoutId).ToListAsync();
        }

        public async Task<Lift?> GetSpecificWorkoutLift(int liftId)
        {
            return await _context.Lift.Where(l => l.Id == liftId).FirstOrDefaultAsync();
        }

        public async Task PostLiftToWorkout(int workoutId, Lift lift)
        {
            var workout = await GetWorkoutByID(workoutId);

            workout.Lift.Add(lift);
        }

        public async Task<IEnumerable<Lift>> GetLifts()
        {
            return await _context.Lift.ToListAsync();
        }

        public async Task<Lift?> GetLiftByID(int liftId)
        {
            return await _context.Lift.Where(l => l.Id == liftId).FirstOrDefaultAsync();
        }

        public async Task<bool> LiftExists(int liftId)
        {
            return await _context.Lift.AnyAsync(l => l.Id == liftId);
        }

        public void DeleteLift(Lift lift)
        {
            _context.Lift.Remove(lift);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        //contact us methods
        public async Task<IEnumerable<ContactUs>> GetProspectiveClients()
        {
            return await _context.ContactUs.OrderBy(c => c.Firstname).ToListAsync();
        }

        public async Task<ContactUs?> GetProspectiveClientById(int prospectiveId)
        {
            return await _context.ContactUs.Where(p => p.Id == prospectiveId).FirstOrDefaultAsync();
        }

        public async Task<bool> ProspectiveExists(int id)
        {
            return await _context.ContactUs.AnyAsync(u => u.Id == id);
        }

        public async Task CreateProspectiveClient(ContactUs contactUs)
        {
            _context.ContactUs.Add(contactUs);
        }

        public void DeleteProspectiveClient(ContactUs contactUs)
        {
            _context.ContactUs.Remove(contactUs);
        }
    }
}