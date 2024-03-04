using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prep1_to_do_list
{
    /// <summary>
    /// Handles the management of tasks including adding, displaying, and removing tasks,
    /// as well as saving and loading the task list from a file.
    /// </summary>
    public class ToDoList
    {
        public List<Task> tasks;

        public ToDoList()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(int taskNumber)
        {
            tasks.Remove(tasks[taskNumber - 1]);
        }

        public void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine(" List is empty. ");
                return;
            }

            Console.WriteLine("==========================+++++++++++========================");
            Console.WriteLine("The existing tasks are:");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + tasks[i]);
            }

            Console.WriteLine("======================END OF LIST============================");
        }
    }
}