using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class ToDolist
    {
         private List<TaskItems> list = new List<TaskItems>();
        public void ReadFromUser()
        {
            char cont = 'y'; int id = 1;
            while (cont != 'n')
            {
                TaskItems task = new TaskItems();
                task.Id = id;
                Console.WriteLine("Enter Task Name");
                task.TaskName = Console.ReadLine();
                Console.WriteLine("Enter Task Duration");
                task.Duration = Console.ReadLine();
                Console.WriteLine("Enter Task state");
                task.Status = Console.ReadLine();
                 list.Add(task);
                Console.WriteLine("press y to insert ,press n to stop");
                cont = Convert.ToChar(Console.ReadLine());
                id++;
            }
            PrintList();

        }


        public void PrintList()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Id + "--" + item.TaskName + "--" + item.Duration + "--" + item.Status);
                Console.WriteLine("*********************");

            }
            Console.WriteLine("To Remove press D ,to Update press U");
            char selection = Convert.ToChar(Console.ReadLine());
            if(selection=='D')
            {
                Console.WriteLine("Enter Task Id");
                int taskid = Convert.ToInt32(Console.ReadLine());
                
                    RemveFromList(taskid);
                
            }
            else if(selection=='U')
            {
                Console.WriteLine("Enter Task Id");
                int taskid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Current State");
                string currentstat = Console.ReadLine();
                UpdateState(taskid, currentstat);
            }
            

        }

        public void RemveFromList(int id)
        {
            var task = list.Find(x => x.Id == id);
            list.Remove(task);
            Console.WriteLine("Task Removed Successfuly");
            PrintList();
        }
        public void UpdateState(int id,string currentstat)
        {
            var task = list.Find(x => x.Id == id);

            task.Status = currentstat;
            Console.WriteLine("Task Update Successfuly");
            PrintList();
        }

    }
}
