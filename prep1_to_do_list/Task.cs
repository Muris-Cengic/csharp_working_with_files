using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prep1_to_do_list
{
    /// <summary>
    /// Represents a single task in the to-do list.
    /// </summary>
    public class Task
    {
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }

        public Task(string title)
        {
            Title = title;
            CreationDate = DateTime.Now;
        }

        public Task(string title, string date)
        {
            Title = title;
            CreationDate = DateTime.Parse(date);
        }
    }
}