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

    public static void Update(Exercise exercise)
    {
        var index = Exercises.FindIndex(e => e.Id == exercise.Id);
        if(index == -1)
            return;

        Exercises[index] = exercise;
    }
}