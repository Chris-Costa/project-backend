using project_backend.Models;

namespace project_backend.Services;

public static class UserService
{
    static List<User> Users { get; }
    static int nextId = 3;
    static UserService()
    {
        Users = new List<User>
        {
            new User { Id = 1, Firstname = "FirstName", Lastname = "LastName", Username = "UserName", Avatar = "", WeightGoal = 180, LikedPosts = [1, 2], Workouts = [{Title = "Workout 1", Lifts = [{Name = "Lift 1", Weight = 45, Sets = 4, Reps = 15}, {Name = "Lift 2", Weight = 75, Sets = 3, Reps = 12}]}, {Title = "Workout 2", Lifts = [{Name = "Lift 1", Weight = 45, Sets = 4, Reps = 15}, {Name = "Lift 2", Weight = 75, Sets = 3, Reps = 12}]}] },
            new User { Id = 2, Firstname = "FirstName2", Lastname = "LastName2", Username = "UserName2", Avatar = "", WeightGoal = 122, LikedPosts = [1], Workouts = [{Title = "Workout 1", Lifts = [{Name = "Lift 1", Weight = 45, Sets = 4, Reps = 15}, {Name = "Lift 2", Weight = 75, Sets = 3, Reps = 12}]}, {Title = "Workout 2", Lifts = [{Name = "Lift 1", Weight = 45, Sets = 4, Reps = 15}, {Name = "Lift 2", Weight = 75, Sets = 3, Reps = 12}]}] }
        };
    }

    public static List<User> GetAll() => Users;

    public static User? Get(int id) => Users.FirstOrDefault(u => u.Id == id);

    public static void Add(User user)
    {
        user.Id = nextId++;
        Users.Add(user);
    }

    public static void Delete(int id)
    {
        var user = Get(id);
        if(user is null)
            return;

        Users.Remove(user);
    }
}