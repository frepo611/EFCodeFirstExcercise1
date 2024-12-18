using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstExcercise1
{
    internal class Database
    {
        public TodoDbContext TaskDb { get; }
        
        public Database(TodoDbContext taskDb)
        {
            TaskDb = taskDb;
        }

        internal void ListAllTasks()
        {
                Console.WriteLine($"{"ID",3} {"Title",-10} {"Resposible",-10}");
                foreach (var task in TaskDb.Tasks)
                {
                    Console.WriteLine($"{task.Id,3} {task.Titel,-10}");
                }
        }
        internal void AddTask()
        {
                bool validText = false;
                string title = String.Empty;
                while (!validText)
                {
                    Console.WriteLine("Enter the task: ");
                    title = Console.ReadLine();
                    if (title != String.Empty) validText = true;
                }
                var newTask = new Models.Task(title);
                TaskDb.Tasks.Add(newTask);
                TaskDb.SaveChanges();
        }
        internal void DeleteTask()
        {
        }
    }
}
