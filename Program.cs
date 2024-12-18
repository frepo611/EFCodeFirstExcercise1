namespace EFCodeFirstExcercise1;

internal class Program
{
    static void Main(string[] args)
    {
        var taskDb = new TodoDbContext();
        var database = new Database(taskDb);
        database.ListAllTasks();
        database.AddTask();

    }
}
