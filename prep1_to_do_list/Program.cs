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

            // Ask user for the input and save a task to new file
            //FileStorage fileStorage = new FileStorage("ToDoList_v3.txt");

            //ToDoList toDoList = new ToDoList();

            //Console.WriteLine("Enter the title of the task:");
            //String taskTitle = Console.ReadLine();

            //Task t1 = new Task(taskTitle);

            //toDoList.AddTask(t1);

            //fileStorage.SaveTasksToFile(toDoList.tasks);


            //Load an existing file from the file system
            FileStorage fileStorage = new FileStorage("ToDoList_v3.txt");

            ToDoList loadedList = fileStorage.LoadToDoListFromFile();

            foreach (Task task in loadedList.tasks)
            {
                Console.WriteLine($"{task.Title}-{task.CreationDate}");
            }


        }
    }
}
