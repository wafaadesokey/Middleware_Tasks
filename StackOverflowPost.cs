using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StackOverflowPost
    {
        public string title { get; private set; }
        public string description { get; private set; }

        public DateTime creationdate { get; private set; }
        private int _upvotevalue = 0;
        private int _downvotevalue = 0;

        public int Upvotevalue{
            get { return _upvotevalue; }
            private set { _upvotevalue = value; }
        }
        public int Downvotevalue
        {
            get { return _downvotevalue; }
            private set { _downvotevalue = value; }
        }

         

        public StackOverflowPost(string title,string description,DateTime datetime)
        {
            this.title = title;
            this.description = description;
            this.creationdate = datetime;
        }

        public void countVotes(int value)
        {
            if (value == 1)
            {
                Upvotevalue++;
            }
            if (value == 0)
            {
                Downvotevalue++;
            }

        }

        

       
        public void RetuenCounter()
        {

            Console.WriteLine($"Up voting={ Upvotevalue} Down voting= {Downvotevalue}");
        }

    }
}
