using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;

using System.Timers;
namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            /////////******Stopwatch********/////////////////
            Stopwatch stop = new Stopwatch();
            Console.WriteLine("To Statrt press 1/ to stop pres 0");
            int key = Convert.ToInt32(Console.ReadLine());
            if (key == 1)
            {
                stop.Start();
                while (!Console.KeyAvailable)
                {
                    Console.Clear();

                    Console.WriteLine("time =" + stop.Elapsed.ToString(@"mm\:ss\:ff"));

                    Thread.Sleep(1000);//sleep one seconed only 1/1000

                }
            }

            stop.Stop();

            /////////******StackOverflowPost********/////////////////


            StackOverflowPost post = new StackOverflowPost("how to implemnt pla pla pla", "c#code", DateTime.Now);
            Console.WriteLine($"{post.title}..{post.description}..{post.creationdate}");

            bool vote = true;
            while (vote)
            {
                Console.WriteLine("to vote up press 1 to vote down press 0,to exit press 2");
                int response = Convert.ToInt32(Console.ReadLine());

                if (response == 1 || response == 0)
                {
                    post.countVotes(response);

                    post.RetuenCounter();

                }
                else
                {
                    vote = false;
                }


            }

            /// post.Downvotevalue = -10; 
            Console.WriteLine(post.Downvotevalue);

        }


    }

}