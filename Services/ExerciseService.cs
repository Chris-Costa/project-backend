using project_backend.Models;

namespace project_backend.Services;

public static class ExerciseService
{
    static List<Exercise> Exercises { get; }
    static int nextId = 3;
    static ExerciseService()
    {
        Exercises = new List<Exercise>
        {
            new Exercise { Id = 1, Name = "Exercise 1", MuscleGroup = "Chest", Description = "Some Description", RepRange = "8-12", Difficulty = "Hard", ImageURL = "www.someURL.com", VideoURL = "www.someVideo.com"},
            new Exercise { Id = 2, Name = "Exercise 12", MuscleGroup = "Back", Description = "Some Description", RepRange = "12-15", Difficulty = "Easy", ImageURL = "www.someURL.com", VideoURL = "www.someVideo.com"}
        };
    }

    public static List<Exercise> GetAll() => Exercises;

    public static Exercise? Get(int id) => Exercises.FirstOrDefault(e => e.Id == id);

    public static void Add(Exercise exercise)
    {
        exercise.Id = nextId++;
        Exercises.Add(exercise);
    }

    public static void Delete(int id)
    {
        var exercise = Get(id);
        if(exercise is null)
            return;

        Exercises.Remove(exercise);
    }
}
/*
public Exercise[] GetAll(ApiVersion version, int user_id)
        {
            var exercises = _context.exercises.Where(e => e.User_id == user_id).Select(e => new Exercise()
            {
                Id = e.Id,
                Name = e.Name,
                MuscleGroup = e.MuscleGroup,
                Description = e.Description,
                RepRange = e.RepRange,
                Difficulty = e.Difficulty,
                ImageURL = e.ImageURL,
                VideoURL = e.VideoURL
            }).OrderBy(e => e.Id).ToArray();

            foreach(Exercise x in exercises)
            {
                x.Link = LinkService.GenerateExercisesLink(version, x.Id); 
            }

            return exercises;
        }
*/