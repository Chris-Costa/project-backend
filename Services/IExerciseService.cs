using project_backend.Entities;

namespace project_backend.Services
{
    public interface IExerciseService
    {
        //get all exercises
        Task<IEnumerable<Exercise>> GetExercises();

        //get individual exercise by id
        Task<Exercise?> GetExerciseByID(int exerciseId);
    }
}