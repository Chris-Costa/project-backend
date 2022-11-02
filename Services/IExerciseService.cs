namespace project_backend.Services
{
    public interface IExerciseRepository
    {
        //get all exercises
        Task<IEnumerable<Exercise>> GetExercises();

        //get individual exercise by id
        Task<Exercise?> GetExerciseByID(int exerciseId);
    }
}