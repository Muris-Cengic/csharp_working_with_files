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

            FileStorage fileStorage = new FileStorage("ToDoList_v3.txt");

            ToDoList toDoList = fileStorage.LoadToDoListFromFile();

            // Console.WriteLine("Enter the title of the task:");
            // String taskTitle = Console.ReadLine();

            // Task t1 = new Task(taskTitle);

            // toDoList.AddTask(t1);

            // fileStorage.SaveTasksToFile(toDoList.tasks);


            //Load an existing file from the file system

            //ToDoList loadedList = fileStorage.LoadToDoListFromFile();

            //foreach (Task task in loadedList.tasks)
            //{
            //    Console.WriteLine($"{task.Title}-{task.CreationDate}");
            //}

            int option;

            do
            {
                Console.WriteLine("Welcome to ToDoList. Choose the option:");
                Console.WriteLine("1. Add task.");
                Console.WriteLine("2. Show existing tasks.");
                Console.WriteLine("3. To remove task");
                Console.WriteLine("9. Save changes.");
                Console.WriteLine("To exit choose 0.");
                Console.Write("Enter your option: ");
                string optionAsString = Console.ReadLine();
                option = int.Parse(optionAsString);

                switch (option)
                {
                    case 1:
                        {
                            Console.Write("Enter the task title: ");
                            string title = Console.ReadLine();

                            Task newTask = new Task(title);

                            toDoList.AddTask(newTask);
                        }; break;
                    case 9:
                        {
                            fileStorage.SaveTasksToFile(toDoList.tasks);
                        }
                        break;
                    case 2:
                        {
                            toDoList.DisplayTasks();
                        } break;

                    case 3:
                        {
                            toDoList.DisplayTasks();
                            Console.Write("Choose the number of task you want to remove: ");
                            string taskToRemove = Console.ReadLine();
                            int taskToRemoveInt = int.Parse(taskToRemove);
                            toDoList.RemoveTask(taskToRemoveInt);
                        } break;
                }

            } while (option != 0);
        }
    }
}
