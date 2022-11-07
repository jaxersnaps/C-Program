namespace RPG
{

    internal class RPG
    {
        static void Main(string[] args)
        {
            /* Introduction */
            Console.WriteLine("Welcome to my RPG");
            Thread.Sleep(1000);
            Console.WriteLine("My name is Jaxson, what's yours?");
            string nameA = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + nameA);
            Thread.Sleep(750);
            Console.WriteLine("You will fall into a sinkhole that would lead you into my dungeon");
            Thread.Sleep(1000);
            Console.WriteLine("Once you fall, you will have to fight and survive in this dungeon full of enemies, and friends.");
            Thread.Sleep(1000);
            Console.WriteLine("I wish you luck surviving these dungeons and making friends along the way.");

            /* Variables for health and damage points*/
            Random rng = new Random();
            int hmin = 5;
            int hmax = 20;
            int dmin = 5;
            int dmax = 10;
            int health = rng.Next(hmin, hmax+1);
            int damage = rng.Next(dmin, dmax+1);
        }
    }
}
