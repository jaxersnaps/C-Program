/* Jaxson Cuttitte 
 * Adventure Story
 * 9 Endings, some are good and some are bad. */
 
namespace MyProject;

internal class MyProject
{
    static void Main(string[] args)
    {
        Console.WriteLine("Say 1,2, or 3 to choose. Say Y or N to reply to yes or no questions.");
        Console.WriteLine("You are walking in a forest, do you keep going or go back to your home? (1,2)");
        string answer1 = Console.ReadLine();
        var ending = 0;
        Random random = new Random();
        switch (answer1)
        {
            case "1":
                Console.WriteLine("You continue walking when suddenly you fall in a large tunnel!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Wake up...");
                Thread.Sleep(300);
                Console.Clear();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Finally you're awake, you shouldn't be here!");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("He");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" will get you..");
                Thread.Sleep(2000);
                Console.WriteLine("\nDon't worry about it right now, you should really leave this place.");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                string x = "OR STAY?";
                for (int i = 0; i < x.Length; i++)
                {
                    Console.Write(x[i]);
                    int pause = random.Next(100, 750);
                    Thread.Sleep(pause);
                }
                Console.ForegroundColor = ConsoleColor.White;

                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("\nWhat are you waiting for? Go!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("You run down the lit up cavern.");
                Console.WriteLine("You see a fork in the mine, there's a door on the left and on the right there is a slanted rock wall.");
                string answer2 = Console.ReadLine();
                switch (answer2)
                {
                    case "1":
                        Console.WriteLine("You grab the door knob and open the door.");
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        string x2 = "TURN AROUND...";
                        for (int i = 0; i < x2.Length; i++)
                        {
                            Console.Write(x2[i]);
                            int pause = random.Next(100, 750);
                            Thread.Sleep(pause);
                        }

                        Console.WriteLine("\nListen to the voice, or keep going?");
                        string answer3 = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        switch (answer3)
                        {
                            case "1":
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string x3 = "GOOD...";
                                for (int i = 0; i < x3.Length; i++)
                                {
                                    Console.Write(x3[i]);
                                    int pause = random.Next(100, 500);
                                    Thread.Sleep(pause);
                                }
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("STUCK ending, you are trapped forever.");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case "2":
                                Console.WriteLine("You continue going, ignoring the voice. The door opens and reveals a glowing white room.");
                                Console.WriteLine("There's a white glowing orb in the middle and a door to your left. What do you do?");
                                string answer5 = Console.ReadLine();
                                switch (answer5)
                                {
                                    case "1":
                                        Console.WriteLine("You grab the orb and the energy flows into you, sending you back to the surface.");
                                        Console.WriteLine("Escaped Ending, you escape the mines and live another day.");
                                        break;
                                    case "2":
                                        Console.WriteLine("You open the next door and you are flung into a strange place, you seem to be in a heaven like place.");
                                        Console.WriteLine("Dead? Ending, you are sent somewhere else and you cannot return to earth.");
                                        break;
                                }
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("You walk over to the edge of the cliff.");
                        Console.WriteLine("Do you rapple down to the next floor or jump down into the cliff?");
                        string answer4 = Console.ReadLine();
                        switch (answer4)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("You rapple down to the next cave floor and theres a sword in a stone, do you take the sword or go down to the last floor?");
                                Thread.Sleep(3500);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                string x5 = "GO DOWN...";
                                for (int i = 0; i < x5.Length; i++)
                                {
                                    Console.Write(x5[i]);
                                    int pause = random.Next(100, 500);
                                    Thread.Sleep(pause);
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                string answer6 = Console.ReadLine();
                                switch (answer6)
                                {
                                    case "1":
                                        Console.WriteLine("You grab the sword when suddenly HE appears. Do you attack or try to run?");
                                        string answer7 = Console.ReadLine();
                                        switch (answer7)
                                        {
                                            case "1":
                                                Console.WriteLine("You jump and stab HIM and he falls to the ground, dead.");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Hero Ending! You slay HIM and the underground is free.");
                                                break;
                                            case "2":
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("You attempt to run but he catches you. Do you attack or try to flee?");
                                                string answer8 = Console.ReadLine();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                string x7 = "THIS IS FATE.";
                                                for (int i = 0; i < x7.Length; i++)
                                                    {
                                                    Console.Write(x7[i]);
                                                    int pause = random.Next(100, 500);
                                                    Thread.Sleep(pause);
                                                }
                                                Console.ForegroundColor = ConsoleColor.White;
                                                switch (answer8)
                                                {
                                                    case "1":
                                                        Console.WriteLine("You stab him and he stabs you. You both fall to the ground, dead.");
                                                        Console.WriteLine("Sacrifice Ending, you kill HIM while killing yourself too.");
                                                        break;
                                                    case "2":
                                                        Console.WriteLine("You are brought to this dungeon and kept in a cage.");
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Caged Ending, you are going to be eaten.");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                    case "2":
                                        Console.WriteLine("You rapple down again and midway the rope is cut, HE looks down at you as you fall forever.");
                                        Console.WriteLine("Tricked ending, you are tricked by HIM and fall forever.");
                                        break;
                                }
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("You free fall down the cave void, and you don't stop falling.");
                                Console.WriteLine("Falling forever ending, you make a mistake and now the only way to die is aging.");
                                break;
                        }
                        break;
                }
                break;

            case "2":
                Console.WriteLine("You leave the forest, but something feels wrong..");
                Console.WriteLine("You got the EARLY ESCAPE ending.");
                break;

        }
    }

}

