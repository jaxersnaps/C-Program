/* Jaxson Cuttitte
 * Count Characters in a String
 * Make a program that counts the number of spaces, tabs, newlines, numbers, and characters.*/
namespace morerandstuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a sentence ending with ~.");
            string sentence = "";
            var spaces = 0;
            var tabs = 0;
            var newlines = 0;
            var count = 0;
            var number = 0;
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                if (key.Key != ConsoleKey.Escape)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        sentence += "\n";
                        Console.WriteLine();
                        newlines++;
                    }
                    else
                    {
                        sentence += Convert.ToChar(key.KeyChar);
                    }
                }

            } while (key.Key != ConsoleKey.Escape);


            for (int i = 0; i < sentence.Length; i++)
            {
                

                count++;
                if (sentence[i] == ' ')
                {
                    spaces++;
                }
                if (sentence[i] == '\t')
                {
                    tabs++;
                }
                if (sentence[1] == '1' && sentence[1] == '2' && sentence[1] == '3' && sentence[1] == '4' && sentence[1] == '5' && sentence[1] == '6' && sentence[1] == '7' && sentence[1] == '8' && sentence[1] == '9' && sentence[1] == '0') 
                {
                    number++;
                }
                

            }
            Console.WriteLine("You wrote " + spaces + " spaces, " + tabs + " tabs, " + newlines + " newlines, " + number + " numbers, and had a total of " + count + " characters.");
        }
        
    }
}