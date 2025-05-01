using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            
            //cheackUserStstues();//isadmin isbanned ialoggedin
            //Console.WriteLine("==========================================================================");

            //duplicatListSize();//duplicate  list size if data size akbr mn al current size
            //Console.WriteLine("==========================================================================");
            //countDivisablebyThree();// find divisbale by 3 
            //Console.WriteLine("==========================================================================");
            //calcuteFactorial();//factorial
            //Console.WriteLine("==========================================================================");

            //Console.WriteLine("==========================================================================");
            //bookingSeats();// cinema seats

            //Console.WriteLine("==========================================================================");

            //testJajjedArry();//seachr task jjaed array
            //testDistionary();
            //countVowels();
            //countLast();
            //  removeDuplicate();
            //int z = 9;
            //Console.WriteLine(z);
            //sumout(out z);//sumref(ref z);
            //Console.WriteLine(z);

            //calcProduct(10,10,out int p,out int k);
            //testDistionary();
            // RemoveSpace();
            // truncateAddReadMore();
            RunTicTac();
            Console.ReadKey();
        }






        public static void RunTicTac()
        {
            char[,] board = new char[3, 3];

            ///print loc
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" | " + board[i, j]);
                }
                Console.Write("\n");

                Console.WriteLine("------------");
            }
            bool result = true; bool iswin = false;
            while (result)
            {
                Console.WriteLine("Enter row no");
                int.TryParse(Console.ReadLine(), out int row);
                Console.WriteLine("Enter col no");
                int.TryParse(Console.ReadLine(), out int col);
                Console.WriteLine("Enter X| Y");
                char.TryParse(Console.ReadLine(), out char currentplayer);
                var cur = board[row, col];
                if (board[row, col] == 0)
                {
                    board[row, col] = currentplayer;
                }
                else
                {
                    Console.WriteLine("Invalid Location");
                }
                iswin=CheackWin(board, currentplayer);
                if(iswin==true)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(" | " + board[i, j]);
                        }
                        Console.Write("\n");

                        Console.WriteLine("------------");
                    }
                    break;
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(" | " + board[i, j]);
                        }
                        Console.Write("\n");

                        Console.WriteLine("------------");
                    }
                }
                
                
            }
            
         

        }

        public static bool CheackWin(char[,] board,char player)
        {
            //cheak rows
             

            string wintext = "**Congratulations...you are the winner";
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                {
                    Console.WriteLine($"{player}"+ wintext);
                    return true;
                }
            }

            //cheak  cols  

            for (int k = 0; k < 3; k++)
            {
                if (board[0, k] == player && board[1, k] == player && board[2, k] == player)
                { Console.WriteLine($"{player}" + wintext); return true; }
            }
            //cheak diagonal 

            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            { Console.WriteLine($"{player}" + wintext); return true; }



            //cheak diagonal bl3aks

            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            { Console.WriteLine($"{player}" + wintext); return true; }


            return false;

        }

        public static void truncateAddReadMore()
        {
            StringBuilder sb = new StringBuilder("");
            //sb.Insert(6, "Beautiful ");  //  6
            //sb.Remove(6, 10);
            //sb.Insert(sb.Length, "type this text ");
            //sb.Replace("text", "Read more");
            sb.Insert(0, "English texts for beginners to practice reading and comprehension online and for free. Practicing your comprehension of written English will both improve your vocabulary ");

            Console.WriteLine("Enter text length you want to show");
            int.TryParse(Console.ReadLine(), out int len);

            int length = sb.Length;
            if (len > length)
            {
                Console.WriteLine(sb.ToString());

            }
            else
            {


                char currentchar = sb[len];
                while (currentchar != ' ')
                {

                    len++;
                    currentchar = sb[len];

                }
                string part = sb.ToString().Substring(0, len);

                string afterCut = part;
                afterCut += "....read more";


                Console.WriteLine(afterCut.ToString());
                // Console.WriteLine(sb.ToString());
                Console.WriteLine("press y to read more");
                string con = Console.ReadLine();
                if (con == "y")
                {
                    Console.WriteLine(sb.ToString());
                }


            }


        }
        public static void RemoveSpace()
        {
            string name = "    *    ALi saef omar    *";
            string r = name;
            name = name.Trim(' ');
            Console.WriteLine(name);
            Console.WriteLine(r);

        }
        public static void sumref(ref int x)
        {
            x = x + 10;
            Console.WriteLine(x);
        }
        public static void sumout(out int x)
        {
            x = 9; x += 10;
            Console.WriteLine();
        }
        public static void removeDuplicate()
        {
            var list2 = new List<int>();
            //int len = list.Count;


            //foreach (var item in list)
            //{
            //    if (item != 4) { list2.Add(item); }
            //}
            //int len = list2.Count;
            //for (int i = 0; i < len; i++)
            //{
            //    Console.WriteLine(list2[i]);
            //}
            ///////////////
            ///
            var list = new List<int> { 2, 5, 4, 4, 9, 4, 3, 6, 4, 4, 4 };

            // list.RemoveAll(x => x == 4);
            for (int i = 0; i < list.Count; i++)
            {
                int b = list[i];
                if (list[i] == 4) { list[i] = 99; }
                //  { list.Remove(list[i]); i--; }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public static void calcProduct(int num1, int num2, out int sum, out int prod)
        {
            sum = num1 * num2;
            prod = num1 * num2;
            Console.WriteLine($"production ={prod}");
        }
        public static void countLast()
        {
            string x = "itt";
            int len = x.Length; int index = -1;
            for (int i = len - 1; i >= 0; i--)
            {
                if (x[i] == 't')
                {
                    index = i; break;
                }
            }
            Console.WriteLine($"index of t={index}");
        }

        public static void countVowels()
        {
            Console.WriteLine("Enter English word");
            string text = Console.ReadLine();
            int count = 0; int countx = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'e' || text[i] == 'i' || text[i] == 'a' || text[i] == 'o' || text[i] == 'u')
                {
                    count++;
                }
            }


            Console.WriteLine("count " + count);
            Console.WriteLine("count " + countx);


        }
        public static void testDistionary()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr.Count());
            Console.WriteLine(arr.Length);
            var list = new List<int> { 20, 30, 50, 55, 42 };
            Console.WriteLine(list.Count());





            string x = null;
            var dic = new Dictionary<string, int>();
            dic.Add("Ali", 50);
            dic.Add("mona", 50);
            dic.Add("heba", 50);
            dic.Add("moh", 50);
            Console.WriteLine("Enter Student Name");
            string Name = Console.ReadLine();
            int score;

            bool res = dic.TryGetValue(Name, out score);
            if (res == true)
            {
                Console.WriteLine($"{Name}   has score {score}");
            }
            else
            {
                Console.WriteLine(Name + "  student not found ");
            }


        }

        public static void TestJajjedArry()
        {
            string[][] jaggedArray = new string[4][];

            // jaggedArray[0] = new string[] {"C#","c++","java" };
            //jaggedArray[1] = new string[] { "html", "css", "javascript" };
            //jaggedArray[2] = new string[] { "React", "Anguler", "vuj" };
            //jaggedArray[3] = new string[] { "SQL", "MongoDB" };

            Console.WriteLine("Enter Number of students");
            int x; string coursename; int coursesperstudents;
            int.TryParse(Console.ReadLine(), out x);
            string[][] jajjedStudents = new string[x][];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter Number of courses For Student No.." + (i + 1));

                int.TryParse(Console.ReadLine(), out coursesperstudents);
                jajjedStudents[i] = new string[coursesperstudents];

                for (int k = 0; k < coursesperstudents; k++)
                {
                    Console.WriteLine("Enter  course No" + (k + 1) + "For Student No.." + (i + 1));
                    coursename = Console.ReadLine();
                    jajjedStudents[i][k] = coursename;
                }

            }


            Console.WriteLine("*******************");

            for (int i = 0; i < jajjedStudents.Length; i++)
            {
                Console.Write("Courses for students no " + (i + 1));
                for (int k = 0; k < jajjedStudents[i].Length; k++)
                {
                    Console.Write("--" + jajjedStudents[i][k] + " ");
                }
                Console.Write("\n");

            }


        }

        public static void BookingSeats()
        {

            Random rnd = new Random(); int x = 0, y = 0; bool validrowindex = false; bool validcolindex = false;
            int[,] seat = new int[5, 5];
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    seat[i, j] = rnd.Next(0, 2); //return rakm btwn(0,1)
                }
            }
            ///print seats
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Console.Write("-" + seat[i, j]);
                }
                Console.Write("\n");
            }

            while (!validrowindex)
            {
                Console.WriteLine("Enter desired row");
                x = Convert.ToInt32(Console.ReadLine());

                if (x < 0 || x > 4)
                {
                    Console.WriteLine(" invalid location  select seat from 1,4");
                }
                else { validrowindex = true; break; }
            }

            while (!validcolindex)
            {
                Console.WriteLine("Enter desired col");
                y = Convert.ToInt32(Console.ReadLine());

                if (y < 0 || y > 4)
                {
                    Console.WriteLine(" invalid location  select seat from 1,4");

                }
                else { validcolindex = true; break; }
            }


            int loc = seat[x, y];
            if (loc == 1)
            {
                Console.WriteLine("opppps seat is booked!! try another one");

            }
            else
            {
                seat[x, y] = 1;
                Console.WriteLine("seat booked sucssuflly");

            }
            //print seats ag=fter booking
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Console.Write("-" + seat[i, j]);
                }
                Console.Write("\n");
            }

        }
        public static void FindMaxuimNumber()
        {
            Console.WriteLine("Enter 5 numbers seorate by ,");
            List<int> num = new List<int>();
            num.Add(4); num.Add(3); num.Add(77); num.Add(-8); num.Add(40);
            num.Sort();
            int count = num.Count();
            Console.WriteLine("Maximum number is =" + num[count - 1]);



        }

        public static void CalcuteFactorial()
        {

            Console.WriteLine("Enter +ve value");
            int x;
            int.TryParse(Console.ReadLine(), out x);

            BigInteger fact = x; int orgval = x;
            if (x < 0) { Console.WriteLine("Cannt calculte factoroal for -ve"); }
            else if (x == 1 || x == 0) { fact = 1; }
            else
            {
                while (x > 1)
                {
                    fact = fact * (x - 1);

                    x--;
                    //if (x == 1) { break; }
                }
            }

            Console.WriteLine("factorial of " + orgval + " = " + fact);



        }

        public static void CountDivisablebyThree()
        {
            int x = 0; int count = 0;
            List<int> ContNums = new List<int>();
            while (x <= 100)
            {
                if (x % 3 == 0)
                {
                    count++;
                    ContNums.Add(x);
                    x++;
                }

                x++;


            }
            Console.WriteLine("Divisable numbers/3  btwn (1-100) =" + count + " Number");
            foreach (var item in ContNums)
            {
                Console.Write(item + " ");
            }
        }

        public static void DuplicatListSize()
        {
            List<int> numbers = new List<int>();
            int previousCapacity = numbers.Capacity;

            Console.WriteLine($"Initial Capacity: {previousCapacity}");

            for (int i = 0; i < 50; i++)
            {
                numbers.Add(i);
                if (previousCapacity != numbers.Capacity)
                {
                    previousCapacity = numbers.Capacity;
                    Console.WriteLine("count=" + numbers.Count + "capacity=" + numbers.Capacity);
                }
            }
        }


        public static void CalcuteSumArray()
        {
            int[] calc = new int[5] { 0, 2, 3, 4, 5 };
            Console.WriteLine("enter any number");
            var input = Console.ReadLine();
            bool isexist = int.TryParse(input, out int x);// calc.Contains(x);

            if (isexist) { Console.WriteLine("Number exist enter another one"); }
            else { Console.WriteLine("Number accepted"); }
            int length = calc.Length;

        }

        public static void CheackUserStstues()
        {

            bool isadmin = true, isloggedin = true, isbanned = false;

            if (isloggedin == true && isadmin == false && isbanned == false) { Console.WriteLine("access granted"); }
            else if (isloggedin == true && isadmin == true && isbanned == false) { Console.WriteLine("Access granted,,Your are an Admin"); }
            else if (isloggedin == true && isadmin == false && isbanned == true) { Console.WriteLine("Access denied,,"); }
            else if (isloggedin == false && isadmin == false && isbanned == false) { Console.WriteLine("Please Loggin"); }
            else if (isloggedin == false && isadmin == true && isbanned == true) { Console.WriteLine(",Your are an Admin but access denied"); }



        }
        public static void TestArrayOprrtions()
        {
            int[,] towd = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 88, 10, 36 } };//2 d array

            for (int i = 0; i < 3; i++)
            {
                for (int v = 0; v < 3; v++)
                {
                    Console.Write(towd[i, v] + " ");
                }
                Console.WriteLine("************");
            }

        }


        public static void PrintList()
        {

            List<int> MyLst = new List<int>();
            MyLst.Add(1); MyLst.Add(2); MyLst.Add(3); MyLst.Add(4);

            Console.WriteLine("Enter test Number");
            int x = Convert.ToInt32(Console.ReadLine());
            bool exist = false;
            foreach (var item in MyLst)
            {
                if (x == item)
                {

                    exist = true;
                    break;
                }

            }
            if (exist == true)
            {
                Console.WriteLine("Number already exist");
            }
            else
            {
                MyLst.Add(x);
                Console.WriteLine("number dosnt exist");
            }

            MyLst.Sort();
            foreach (var item in MyLst)
            {
                Console.WriteLine(item);
                Console.WriteLine("***");

            }

        }

        public static void EditArray(int[] num)
        {

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i * 9;


            }
            Console.WriteLine("Values From function");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
        public static void SumArry()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 2;


            }


            int x = 1000; int sum = 0; bool exist = false; int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (x == arr[i])
                {
                    exist = true; index = 0;
                    break;
                }


            }
            { Console.WriteLine(sum + " YES Number Exist at index "); }
            if (exist == true) { Console.WriteLine(x + " YES Number Exist at index "); }
            else { Console.WriteLine(x + " NO Number Dosent Exist"); }



        }
        public static void PrintNumbers()
        {
            for (int i = 0; i <= 10; i++)
            {

                Console.WriteLine(" current No is  Number=" + i);


            }
        }

        public static void PrintEvenNumbers()
        {
            for (int i = 0; i <= 10; i++)
            {


                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " Is Even Number");

                }



            }
        }

        public static void TestWhile()
        {
            int x = 0;
            while (x <= 18)
            {
                if (x == 5 || x == 7 || x == 15)
                {
                    x++;
                    continue;
                }
                else
                {
                    Console.WriteLine(x); x++;
                }

            }
        }

        public static void print(int start)
        {
            start = start += 10;
            Console.WriteLine("Current value from Function  =" + start);
        }

    }
}
