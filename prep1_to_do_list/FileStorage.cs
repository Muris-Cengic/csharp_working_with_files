using System;
using System.Collections.Generic;
using System.Linq;
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
            // Implementation omitted for summary
        }

        /// <summary>
        /// Loads tasks from the specified file, deserializing each line into a Task object.
        /// If the file does not exist, it returns an empty list, indicating no tasks to load.
        /// </summary>
        /// <returns>A list of Task objects loaded from the file.</returns>
        public List<Task> LoadTasksFromFile()
        {
            List<Task> tasks = new List<Task>();
            // Implementation omitted for summary

            return tasks;
        }
    }
}
