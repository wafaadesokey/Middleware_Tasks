using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentGrades
    {
        public Dictionary <int, int> grades = new Dictionary<int,int>();

        

        public StudentGrades()
        {
            grades[0] = 90; grades[1] = 80; grades[2] = 88; grades[2] = 99; grades[4] = 93;
        }
        public int this[int index]
        {
             get
            {
                if (grades.ContainsKey(index))
                {
                    return grades[index];
                }
                else return-1;
            }
            set
            {
                grades[index] = value;
            }
        }

        public Dictionary<string ,string> JobTitle = new Dictionary<string, string>();

        public string this[string employeename]
        {
            get
            {
                if (JobTitle.ContainsKey(employeename))
                {
                    return JobTitle[employeename];
                }
                else
                {
                    return "Not found";
                }
            }
            set
            {
                JobTitle[employeename] = value;
            }
        }
             




    }
}
