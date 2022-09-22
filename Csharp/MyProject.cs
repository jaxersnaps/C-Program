namespace MyProject
{

    internal class MyProject
    {
        static void Main(string[] args)
        {
            var num = 0;
            while (num < 10)
            {
                num += 1;
                Console.WriteLine(num);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Counted to ten!");
        }
    }
}
