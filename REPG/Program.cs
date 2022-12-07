namespace RPG
{

    internal class RPG
    {
        static void Main(string[] args)
        {
            /* Introduction */
            Console.WriteLine("Welcome to my RPG");
            Console.WriteLine("My name is Jaxson, what's yours?");
            string nameA = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + nameA);
            Console.WriteLine("You will fall into a sinkhole that would lead you into my dungeon");
            Console.WriteLine("Once you fall, you will have to fight and survive in this dungeon full of enemies, and friends.");
            Console.WriteLine("I wish you luck surviving these dungeons and making friends along the way.");
            Thread.Sleep(5000);
            /* Variables for health and damage points*/
            Random rng = new Random();
            int hmin = 5;
            int hmax = 20; 
            int dmin = 5;
            int dmax = 10;
            int health = rng.Next(hmin, hmax+1);
            int damage = rng.Next(dmin, dmax+1);
            bool run = true;
            string[] items = { "Wooden Sword", "Metal Sword", "Silver Sword"};
            int[] scrapamount = { 10, 15, 20 };
            int[] goldamount = { 5, 10, 15 };
            int[] scrapcost = { 20, 30 };
            int[] goldcost = { 10, 20 };
            var inv1 = "Wooden Sword";
            var inv2 = "Metal Sword";
            var inv3 = "Silver Sword";
            int scrap = 0;
            int gold = 0;
            bool item1used = false;
            bool item2used = false;
            bool item3used = false;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("inv for Inventory");
                Console.WriteLine("move (direction) to move a direction. example: move up");
                Console.WriteLine("exit to exit the game");
                string opt1 = Console.ReadLine();
                if (opt1 == "inv")
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine("Scrap: " + scrap);
                    Console.WriteLine("Gold: " + gold);
                    Console.WriteLine("Slot 1: " + inv1);
                    Console.WriteLine("Slot 2: " + inv2);
                    Console.WriteLine("Slot 3: " + inv3);
                    Console.WriteLine("1, 2, 3, or exit to select item or quit inventory menu.");
                    Console.WriteLine("----------------");
                    string invchoice = Console.ReadLine();
                    if (invchoice == "1" && inv1 != "Empty")
                    {
                        if (item1used == false)
                        {
                            Console.WriteLine("Equip, Scrap, or Upgrade? (1,2,3)");
                            string itemchoice = Console.ReadLine();
                            if (itemchoice == "1")
                            {
                                item1used = true;
                                Console.WriteLine("Equipped");
                                Thread.Sleep(1000);
                            }
                            else if (itemchoice == "2")
                            {
                                item1used = false;
                                inv1 = "Empty";
                                if (inv1 == items[0])
                                {
                                    scrap += scrapamount[0];
                                    gold += goldamount[0];
                                }
                                else if (inv1 == items[1])
                                {
                                    scrap += scrapamount[1];
                                    gold += goldamount[0];
                                }
                                else if (inv1 == items[2])
                                {
                                    scrap += scrapamount[2];
                                    gold += goldamount[0];
                                }
                                Console.WriteLine("Scrapped");
                                Console.WriteLine("Scrap: " + scrap);
                                Console.WriteLine("Gold: " + gold);
                                Thread.Sleep(1000);
                            }
                            else if (itemchoice == "3")
                            {
                                if (inv1 == items[0])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[0]);
                                    Console.WriteLine("Gold Cost: " + goldcost[0]);
                                    Thread.Sleep(1000);
                                }
                                else if (inv1 == items[1])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[1]);
                                    Console.WriteLine("Gold Cost: " + goldcost[1]);
                                    Thread.Sleep(1000);
                                }
                                else if (inv1 == items[2])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[2]);
                                    Console.WriteLine("Gold Cost: " + goldcost[2]);
                                    Thread.Sleep(1000);
                                }
                                Console.WriteLine("Upgrade? y,n");
                                string upgradechoice = Console.ReadLine();
                                if (upgradechoice == "y")
                                {
                                    if (inv1 == items[0])
                                    {
                                        inv1 = items[1];
                                    }
                                    else if (inv1 == items[1])
                                    {
                                        inv1 = items[2];
                                    }
                                }
                            }
                        } else
                        {
                            Console.WriteLine("Unequip, Scrap, or Upgrade? (1,2,3)");
                            string itemchoice = Console.ReadLine();
                            if (itemchoice == "1")
                            {
                                item1used = false;
                                Console.WriteLine("Unequipped");
                                Thread.Sleep(1000);
                            }
                            else if (itemchoice == "2")
                            {
                                item1used = false;
                                inv1 = "Empty";
                                scrap += 10;
                                Console.WriteLine("Scrapped");
                                Console.WriteLine("scrap: " + scrap);
                                Thread.Sleep(1000);
                            }
                            else if (itemchoice == "3")
                            {
                                if (inv1 == items[0])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[0]);
                                    Console.WriteLine("Gold Cost: " + goldcost[0]);
                                    Thread.Sleep(1000);
                                }
                                else if (inv1 == items[1])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[1]);
                                    Console.WriteLine("Gold Cost: " + goldcost[1]);
                                    Thread.Sleep(1000);
                                }
                                else if (inv1 == items[2])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[2]);
                                    Console.WriteLine("Gold Cost: " + goldcost[2]);
                                    Thread.Sleep(1000);
                                }
                                Console.WriteLine("Upgrade? y,n");
                                string upgradechoice = Console.ReadLine();
                                if (upgradechoice == "y")
                                {
                                    if (inv1 == items[0])
                                    {
                                        inv1 = items[1];
                                    }
                                    else if (inv1 == items[1])
                                    {
                                        inv1 = items[2];
                                    }
                                }
                            }
                        }
                    } else
                    {
                        if (invchoice == "1")
                        {
                            Console.WriteLine("Slot 1 is empty.");
                            Thread.Sleep(1000);
                        }
                        else if (invchoice == "2")
                        {
                            Console.WriteLine("Slot 2 is empty.");
                            Thread.Sleep(1000);
                        }
                        else if (invchoice == "3")
                        {
                            Console.WriteLine("Slot 3 is empty.");
                            Thread.Sleep(1000);
                        }
                    }

                }
            }
        }
    }
}
