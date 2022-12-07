namespace ASCII_Animation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            var count = 0;
            var count2 = 0;
            var count3 = 0;
            bool run = true; 
            while (run)
            {
                count = 0;
                count2 = 0;
                count3 = 0;
                Console.WriteLine("1,2,3 to choose an Ascii Animation");
                Console.WriteLine("1. Dancing Emoji");
                Console.WriteLine("2. Smile");
                Console.WriteLine("3. Throwing Emoji");
                Console.WriteLine("4. Exit");
                var answer = Console.ReadLine();
                if (answer=="1")
                {
                    while (count < 5)
                    {
                        Console.WriteLine(@"\(^o^)/");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("--(^o^)--");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine(@"__(^o^)__");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine(@"--(^o^)--");
                        Thread.Sleep(500);
                        Console.Clear();
                        count++;
                    }
                }
                if (answer=="2")
                {
                    while (count2 < 5)
                    {
                        Console.WriteLine(@" | | ");
                        Console.WriteLine(@"  *  ");
                        Console.WriteLine(@"\___/");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine(@" | | ");
                        Console.WriteLine(@"  *  ");
                        Console.WriteLine(@"_____");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine(@" | | ");
                        Console.WriteLine(@"  *  ");
                        Console.WriteLine(@" ___");
                        Console.WriteLine(@"/   \ ");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine(@" | | ");
                        Console.WriteLine(@"  *  ");
                        Console.WriteLine(@"_____");
                        Thread.Sleep(500);
                        Console.Clear();
                        count2++;
                    }
                }
                if (answer=="3")
                {
                    while (count3 < 5)
                    {
                        Console.WriteLine(@"(/*#*)/- |_|");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine(@"(/*#*)/--  |_|");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine(@"(/*#*)/---   |_|");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine(@"(/*#*)/--  |_|");
                        Thread.Sleep(500);
                        Console.Clear();
                        count3++;
                    }
                }
                if (answer=="4")
                {
                    run = false;
                }
            }
        }
    }
}