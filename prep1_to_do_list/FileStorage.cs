using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prep1_to_do_list
{
    /// <summary>
    /// Manages file input/output operations for tasks in a to-do list application. This class is responsible for
    /// saving tasks to a file and loading tasks from a file, encapsulating all file-related operations to ensure
    /// separation of concerns within the application. It allows for persistent storage of tasks, enabling the application
    /// to maintain state.
    /// </summary>
    public class FileStorage
    {
        private string filePath;


        /// <summary>
        /// Initializes a new instance of the TaskFileStorage class with the specified file path.
        /// </summary>
        /// <param name="filePath">The path to the file where tasks will be saved and loaded.</param>
        public FileStorage(string filePath)
        {
            this.filePath = filePath;
        }

        /// <summary>
        /// Saves a list of tasks to the specified file, overwriting any existing content.
        /// Each task is serialized into a string format and written to the file.
        /// </summary>
        /// <param name="tasks">The list of Task objects to be saved to the file.</param>
        public void SaveTasksToFile(List<Task> tasks)
        {
            using StreamWriter writer = new StreamWriter(filePath);

            foreach (var task in tasks)
            {
                writer.WriteLine($"{task.Title} - {task.CreationDate}");
            }
        }

        /// <summary>
        /// Loads tasks from the specified file, deserializing each line into a Task object.
        /// If the file does not exist, it returns an empty list, indicating no tasks to load.
        /// </summary>
        /// <returns>A list of Task objects loaded from the file.</returns>
        public ToDoList LoadToDoListFromFile()
        {
            ToDoList list = new ToDoList();

            try
            {
                // line = "Task 1-2024/02/16"

                // Task 1 : string
                // 2024/02/16 : DateTime
                // new Task("Task 1", "2024/02/16")
                using (StreamReader file = new StreamReader(filePath))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        // list.AddTask();
                        string[] parts = line.Split('-');

                        string Title, date;
                        Title = parts[0];
                        date = parts[1];

                        Task task = new Task(Title, date);

                        list.AddTask(task);

                        // Task task = new Task(parts[0], parts[1]);

                    }
                }
                // Implementation omitted for summary
                //Hi
                return list;
            }
            catch (Exception e)
            {
                return list;
            }
        }
    }
}