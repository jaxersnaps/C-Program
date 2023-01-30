/* Jaxson Cuttitte
 * Square root reducer, write a program that simplifies integer square roots. */
namespace squarerootreducer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {

                Console.WriteLine("Enter Number");
                int number = Convert.ToInt32(Console.ReadLine());
                (int outside, int inside) = RootReducer(number);
                Console.WriteLine("Square Factor: " + outside);
                Console.WriteLine(outside + " √ " + inside);
                Console.WriteLine("exit to exit code");
                string exit = Console.ReadLine();
                if (exit == "exit")
                {
                    run = false;
                }

            }

        }
        static (int, int) RootReducer(int number)
        {
            int outside = 1, inside = 1;
            for (int i = 1; i < number; i++)
            {
                if (number % (i * i) == 0)
                {
                    outside = i;
                    inside = number / (i * i);
                }
            }
            return (outside, inside);
        }
    }
}