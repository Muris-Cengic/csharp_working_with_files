using System;

namespace prep1_to_do_list
{
    /// <summary>
    /// The Program class serves as the entry point for the to-do list application. It is responsible for
    /// displaying the user interface and handling user interactions. Through this class, users can add tasks,
    /// view the list of tasks, remove all tasks, and load or save tasks from/to a file. This class utilizes
    /// the ToDoList and FileStorage classes to manage tasks and their persistence, providing a simple
    /// console-based interface for to-do list management.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStorage fileStorage = new FileStorage("ToDoList.txt");

            ToDoList toDoList = new ToDoList();

            Console.WriteLine("Enter the title of the task:");
            String taskTitle = Console.ReadLine();

            Task t1 = new Task(taskTitle);

            toDoList.AddTask(t1);

            fileStorage.SaveTasksToFile(toDoList.tasks);
            fileStorage.writer.Close();

        }
    }
}
