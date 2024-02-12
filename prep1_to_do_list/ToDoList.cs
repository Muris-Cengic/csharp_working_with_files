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
        public string filePath { get; }
        public ToDoList(string filePath)
        {
            this.filePath = filePath;
        }      
    }
}
