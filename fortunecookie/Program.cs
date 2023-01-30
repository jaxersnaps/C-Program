/* Jaxson Cuttitte
 * Fortune Cookie Assignment, write a program that is passed a number and gives the user a fortune. */
namespace fortunecookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Input a number to get a fortune or type 0 to exit. 1-10");
                num = Convert.ToInt32(Console.ReadLine());
                if (num != 0)
                {
                    string fortune = FortuneCookie(num);
                    Console.WriteLine(fortune);
                }
            } while (num != 0);
        }
        static String FortuneCookie(int num)
        {
            string fortune = "";
            if (num == 1)
            {
                fortune = "You will find a penny on the ground tomorrow.";
            }
            else if (num == 2)
            {
                fortune = "You will win the lottery once in your lifetime.";
            }
            else if (num == 3)
            {
                fortune = "In a few seconds, you will breathe again.";
            }
            else if (num == 4)
            {
                fortune = "You will get an A on your next test.";
            }
            else if (num == 5)
            {
                fortune = "You will be very successful in your future.";
            }
            else if (num == 6)
            {
                fortune = "You will become very good at the sport/instrument you play.";
            }
            else if (num == 7)
            {
                fortune = "Look up and you will see a dollar on the ceiling.";
            }
            else if (num == 8)
            {
                fortune = "2023 will be the best year for you.";
            }
            else if (num == 9)
            {
                fortune = "Your code will work without any errors.";
            }
            else if (num == 10)
            {
                fortune = "You will never forget a semi-colon in your code.";
            }
            return fortune;
        }
    }
}