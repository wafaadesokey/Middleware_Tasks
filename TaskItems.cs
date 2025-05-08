using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public  class TaskItems
    {
        public int Id;
        public string TaskName;
        public string Duration;
        public string Status;
       // public List<TaskItems> list = new List<TaskItems>();
        public TaskItems()
        { }
        public TaskItems(string TaskName, string Duration, string Status)
        {
            this.TaskName = TaskName;
            this.Duration = Duration;
            this.Status = Status;

        }

      

    }
}
