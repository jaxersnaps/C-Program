namespace wordreverser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string to be reversed.");
            string original = Console.ReadLine();
            string reverse = "";
            reverse = Reverser(original);
            Console.WriteLine(reverse);
        }
        static String Reverser(String original)
        {
            string reverse = "";
            for (int i = original.Length - 1; i >= 0; i--)
            {
                reverse += original[i];
            }
            return reverse;
        }
    }
}