using project_backend.Entities;

namespace project_backend.Services
{
    public interface IExerciseService
    {
        Task<IEnumerable<Exercise>> GetExercises();

        Task<Exercise?> GetExerciseByID(int exerciseId);

        Task<Exercise?> GetExerciseByName(string name);

        Task<bool> ExerciseExists(int exerciseId);
    }
}