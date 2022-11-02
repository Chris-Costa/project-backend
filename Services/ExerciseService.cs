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
            //order by used for name currently maybe category later
            return await _context.Exercises.OrderBy(e => e.Name).ToListAsync();
        }

        public async Task<Exercise?> GetExerciseByID(int exerciseId)
        {
            return await _context.Exercises.Where(e => e.Id == exerciseId).FirstOrDefaultAsync();
        }

    }
}