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
        static ToDoList toDoList = new ToDoList("tasks.txt");
        static void Main(string[] args)
        {
            //Provide user interface 
        }
    }
}
