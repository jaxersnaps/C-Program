//Get GCF and Reduce fractions in a function
namespace fractionreducer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                
                Console.WriteLine("Enter First Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int gcf = GCF(num1, num2);
                Console.WriteLine("GCF: " + gcf);
                int total1 = num1 / gcf;
                int total2 = num2 / gcf;
                Console.WriteLine("Reduced Fraction: " + total1 + "/" + total2);
                Console.WriteLine("exit to exit code");
                string exit = Console.ReadLine();
                if (exit == "exit")
                {
                    run = false;
                }

            }
            
        }
        static int GCF(int num1, int num2)
        {
            
            int gcf = 1;
            for (int i = 2; i <= num1; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    gcf = i;
                }
            }
            return gcf;

        }
    }
}