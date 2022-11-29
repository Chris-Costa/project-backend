using project_backend.Entities;
using project_backend.Data;
using Microsoft.EntityFrameworkCore;

namespace project_backend.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly CVFitContext _context;

        public ExerciseService(CVFitContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Exercise>> GetExercises()
        {
            return await _context.Exercises.OrderBy(e => e.Name).ToListAsync();
        }

        public async Task<Exercise?> GetExerciseByID(int exerciseId)
        {
            return await _context.Exercises.Where(e => e.Id == exerciseId).FirstOrDefaultAsync();
        }

        public async Task<bool> ExerciseExists(int exerciseId)
        {
            return await _context.Exercises.AnyAsync(e => e.Id == exerciseId);
        }
    }
}