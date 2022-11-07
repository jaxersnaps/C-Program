/*Looping Quiz By Jaxson
 * Start with one of the two quizzes you made previously and make it so that each question must be answered correctly before going to the next question.*/
using System.Text;
namespace Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var run = 1;
            var pass1 = 0;
            var pass2 = 0;
            var pass3 = 0;
            Console.WriteLine("Welcome to my quiz! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Good luck, " + name);
            while (run==1)
            {
                run = 0;
                while (pass1 == 0) 
                {
                    
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Question 1");
                    Console.WriteLine("What is the answer to life, the universe, and everything?");
                    Console.WriteLine("\t1. 32");
                    Console.WriteLine("\t2. Monkeys");
                    Console.WriteLine("\t3. There is no answer");
                    Console.WriteLine("\t4. 23");
                    int answer1 = Convert.ToInt32(Console.ReadLine());
                    if (answer1==1)
                    {
                        Console.WriteLine("Good job!");
                        pass1=1;
                    }
                    else if (answer1==2 || answer1==3 || answer1==4)
                    {
                        Console.WriteLine("Wrong, try again.");
                    }
                }
                while (pass2 == 0)
                {

                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Question 2");
                    Console.WriteLine("Is a bagel a donut");
                    Console.WriteLine("\t1. Yes");
                    Console.WriteLine("\t2. No");
                    Console.WriteLine("\t3. Maybe");
                    Console.WriteLine("\t4. I don't know");
                    int answer1 = Convert.ToInt32(Console.ReadLine());
                    if (answer1 == 2)
                    {
                        Console.WriteLine("Good job!");
                        pass2 = 1;
                    }
                    else if (answer1 == 1 || answer1 == 3 || answer1 == 4)
                    {
                        Console.WriteLine("Wrong, try again.");
                    }
                }
                while (pass3 == 0)
                {

                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Question 3");
                    Console.WriteLine("What is the best animal?");
                    Console.WriteLine("\t1. Tiger");
                    Console.WriteLine("\t2. Elephant");
                    Console.WriteLine("\t3. Shark");
                    Console.WriteLine("\t4. Monkey");
                    int answer1 = Convert.ToInt32(Console.ReadLine());
                    if (answer1 == 4)
                    {
                        Console.WriteLine("Good job!");
                        pass3 = 1;
                    }
                    else if (answer1 == 1 || answer1 == 2 || answer1 == 3)
                    {
                        Console.WriteLine("Wrong, try again.");
                    }
                }
                Console.WriteLine("Do you want to run again? y or n");
                var restart = Console.ReadLine();
                switch (restart)
                {
                    case "y":
                        run = 1;
                        pass1 = 0;
                        pass2 = 0;
                        pass3 = 0;
                        break;
                    case "n":

                        break;
                        
                }
            }
            
        }
    }
}