namespace RPG
{

    internal class RPG
    {
        static void Main(string[] args)
        {
            /* Introduction */
            Console.WriteLine("Welcome to my RPG");
            Console.WriteLine("What's your name?");
            string nameA = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + nameA);
            Console.WriteLine("You will fall into a sinkhole that would lead you into my dungeon");
            Console.WriteLine("Once you fall, you will have to fight and survive in this dungeon full of things.");
            Console.WriteLine("I wish you luck surviving these dungeons.");
            Console.WriteLine("Press any button to continue.");
            Console.ReadLine();
            /* Variables for health and damage points*/
            Random rng = new Random();
            int hmin = 5;
            int hmax = 20;
            int dmin = 5;
            int dmax = 10;
            int health = rng.Next(hmin, hmax + 1);
            int damage = rng.Next(dmin, dmax + 1);
            int enemyhealth;
            int enemydamage;
            bool run = true;
            string[] items = { "Wooden Sword", "Metal Sword", "Silver Sword" };
            int[] scrapamount = { 10, 15, 20 };
            int[] goldamount = { 5, 10, 15 };
            int[] scrapcost = { 20, 30, 40 };
            int[] goldcost = { 10, 20, 30 };
            string[] room = { };
            int roomnum = 0;
            string inv1 = "Wooden Sword";
            string inv2 = "Wooden Sword";
            string inv3 = "Wooden Sword";
            int scrap = 0;
            int gold = 0;
            bool item1used = false;
            bool item2used = false;
            bool item3used = false;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("inv for Inventory.");
                Console.WriteLine("move (Direction) to move a direction. (Example: move up)");
                Console.WriteLine("items to view descriptions to find costs and amounts for items.");
                Console.WriteLine("exit to exit the game.");
                string opt1 = Console.ReadLine();
                if (opt1 == "inv")
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine("Scrap: " + scrap);
                    Console.WriteLine("Gold: " + gold);
                    Console.WriteLine("Health: " + health);
                    Console.WriteLine("Damage: " + damage);
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
                            if (itemchoice == "2")
                            {
                                if (inv1 == items[0])
                                {
                                    Console.WriteLine(scrapamount[0]);
                                    scrap += scrapamount[0];
                                    gold += goldamount[0];
                                }
                                if (inv1 == items[1])
                                {
                                    Console.WriteLine(scrapamount[1]);
                                    scrap += scrapamount[1];
                                    gold += goldamount[1];
                                }
                                if (inv1 == items[2])
                                {
                                    Console.WriteLine(scrapamount[2]);
                                    scrap += scrapamount[2];
                                    gold += goldamount[2];
                                }
                                Console.WriteLine("Scrapped");
                                Console.WriteLine("Scrap: " + scrap);
                                Console.WriteLine("Gold: " + gold);
                                item1used = false;
                                inv1 = "Empty";
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "3")
                            {
                                if (inv1 == items[0])
                                {
                                    if (gold >= scrapcost[0] && scrap >= goldcost[0])
                                    {
                                        Console.WriteLine("Scrap Cost: " + scrapcost[0]);
                                        Console.WriteLine("Gold Cost: " + goldcost[0]);
                                        
                                        Thread.Sleep(1000);
                                    }
                                    
                                }
                                if (inv1 == items[1])
                                {
                                    if (gold >= scrapcost[1] && scrap >= goldcost[1])
                                    {
                                        Console.WriteLine("Scrap Cost: " + scrapcost[1]);
                                        Console.WriteLine("Gold Cost: " + goldcost[1]);
                                        
                                        Thread.Sleep(1000);
                                    }
                                        
                                }
                                if (inv1 == items[2])
                                {
                                    if (gold >= scrapcost[2] && scrap >= goldcost[2])
                                    {
                                        Console.WriteLine("Scrap Cost: " + scrapcost[2]);
                                        Console.WriteLine("Gold Cost: " + goldcost[2]);
                                        Thread.Sleep(1000);
                                    }
                                        
                                }
                                if (inv1 == items[0] && scrap >= scrapcost[0] && gold >= goldcost[0])
                                {
                                    inv1 = items[1];
                                    Console.WriteLine("Upgraded to Metal Sword!");
                                    scrap -= scrapcost[0];
                                    gold -= goldcost[0];
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);
                                    Thread.Sleep(1000);
                                }
                                else if (inv1 == items[1] && scrap >= scrapcost[1] && gold >= goldcost[1])
                                {
                                    inv1 = items[2];
                                    Console.WriteLine("Upgraded to Silver Sword!");
                                    scrap -= scrapcost[1];
                                    gold -= goldcost[1];
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);
                                    Thread.Sleep(1000);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Unequip, Scrap, or Upgrade? (1,2,3)");
                            string itemchoice = Console.ReadLine();
                            if (itemchoice == "1")
                            {
                                item1used = false;
                                Console.WriteLine("Unequipped");
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "2")
                            {

                                if (inv1 == items[0])
                                {
                                    scrap += scrapamount[0];
                                    gold += goldamount[0];
                                }
                                if (inv1 == items[1])
                                {
                                    scrap += scrapamount[1];
                                    gold += goldamount[1];
                                }
                                if (inv1 == items[2])
                                {
                                    scrap += scrapamount[2];
                                    gold += goldamount[2];
                                }
                                Console.WriteLine("Scrapped");
                                Console.WriteLine("Scrap: " + scrap);
                                Console.WriteLine("Gold: " + gold);
                                item1used = false;
                                inv1 = "Empty";
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "3")
                            {
                                if (inv1 == items[0])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[0]);
                                    Console.WriteLine("Gold Cost: " + goldcost[0]);
                                    scrap -= scrapcost[0];
                                    gold -= goldcost[0];
                                    Thread.Sleep(1000);
                                }
                                if (inv1 == items[1])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[1]);
                                    Console.WriteLine("Gold Cost: " + goldcost[1]);
                                    scrap -= scrapcost[1];
                                    gold -= goldcost[1];
                                    Thread.Sleep(1000);
                                }
                                if (inv1 == items[2])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[2]);
                                    Console.WriteLine("Gold Cost: " + goldcost[2]);
                                    scrap -= scrapcost[2];
                                    gold -= goldcost[2];
                                    Thread.Sleep(1000);
                                }
                                if (inv1 == items[0])
                                {
                                    inv1 = items[1];
                                    Console.WriteLine("Upgraded to Metal Sword!");
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);
                                    Thread.Sleep(1000);
                                }
                                else if (inv1 == items[1])
                                {
                                    inv1 = items[2];
                                    Console.WriteLine("Upgraded to Silver Sword!");
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);

                                    Thread.Sleep(1000);
                                }
                            }
                        }
                    }
                    if (invchoice == "2" && inv2 != "Empty")
                    {
                        if (item2used == false)
                        {
                            Console.WriteLine("Equip, Scrap, or Upgrade? (1,2,3)");
                            string itemchoice = Console.ReadLine();
                            if (itemchoice == "1")
                            {
                                item2used = true;
                                Console.WriteLine("Equipped");
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "2")
                            {
                                if (inv2 == items[0])
                                {
                                    Console.WriteLine(scrapamount[0]);
                                    scrap += scrapamount[0];
                                    gold += goldamount[0];
                                }
                                if (inv2 == items[1])
                                {
                                    Console.WriteLine(scrapamount[1]);
                                    scrap += scrapamount[1];
                                    gold += goldamount[1];
                                }
                                if (inv2 == items[2])
                                {
                                    Console.WriteLine(scrapamount[2]);
                                    scrap += scrapamount[2];
                                    gold += goldamount[2];
                                }
                                Console.WriteLine("Scrapped");
                                Console.WriteLine("Scrap: " + scrap);
                                Console.WriteLine("Gold: " + gold);
                                item2used = false;
                                inv2 = "Empty";
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "3")
                            {
                                if (inv2 == items[0])
                                {
                                    if (gold >= scrapcost[0] && scrap >= goldcost[0])
                                    {
                                        Console.WriteLine("Scrap Cost: " + scrapcost[0]);
                                        Console.WriteLine("Gold Cost: " + goldcost[0]);

                                        Thread.Sleep(1000);
                                    }

                                }
                                if (inv2 == items[1])
                                {
                                    if (gold >= scrapcost[1] && scrap >= goldcost[1])
                                    {
                                        Console.WriteLine("Scrap Cost: " + scrapcost[1]);
                                        Console.WriteLine("Gold Cost: " + goldcost[1]);

                                        Thread.Sleep(1000);
                                    }

                                }
                                if (inv2 == items[2])
                                {
                                    if (gold >= scrapcost[2] && scrap >= goldcost[2])
                                    {
                                        Console.WriteLine("Scrap Cost: " + scrapcost[2]);
                                        Console.WriteLine("Gold Cost: " + goldcost[2]);
                                        Thread.Sleep(1000);
                                    }

                                }
                                if (inv2 == items[0] && scrap >= scrapcost[0] && gold >= goldcost[0])
                                {
                                    inv2 = items[1];
                                    Console.WriteLine("Upgraded to Metal Sword!");
                                    scrap -= scrapcost[0];
                                    gold -= goldcost[0];
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);
                                    Thread.Sleep(1000);
                                }
                                else if (inv1 == items[1] && scrap >= scrapcost[1] && gold >= goldcost[1])
                                {
                                    inv2 = items[2];
                                    Console.WriteLine("Upgraded to Silver Sword!");
                                    scrap -= scrapcost[1];
                                    gold -= goldcost[1];
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);
                                    Thread.Sleep(1000);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Unequip, Scrap, or Upgrade? (1,2,3)");
                            string itemchoice = Console.ReadLine();
                            if (itemchoice == "1")
                            {
                                item2used = false;
                                Console.WriteLine("Unequipped");
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "2")
                            {

                                if (inv2 == items[0])
                                {
                                    scrap += scrapamount[0];
                                    gold += goldamount[0];
                                }
                                if (inv2 == items[1])
                                {
                                    scrap += scrapamount[1];
                                    gold += goldamount[1];
                                }
                                if (inv2 == items[2])
                                {
                                    scrap += scrapamount[2];
                                    gold += goldamount[2];
                                }
                                Console.WriteLine("Scrapped");
                                Console.WriteLine("Scrap: " + scrap);
                                Console.WriteLine("Gold: " + gold);
                                item2used = false;
                                inv2 = "Empty";
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "3")
                            {
                                if (inv2 == items[0])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[0]);
                                    Console.WriteLine("Gold Cost: " + goldcost[0]);
                                    scrap -= scrapcost[0];
                                    gold -= goldcost[0];
                                    Thread.Sleep(1000);
                                }
                                if (inv2 == items[1])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[1]);
                                    Console.WriteLine("Gold Cost: " + goldcost[1]);
                                    scrap -= scrapcost[1];
                                    gold -= goldcost[1];
                                    Thread.Sleep(1000);
                                }
                                if (inv2 == items[2])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[2]);
                                    Console.WriteLine("Gold Cost: " + goldcost[2]);
                                    scrap -= scrapcost[2];
                                    gold -= goldcost[2];
                                    Thread.Sleep(1000);
                                }
                                if (inv2 == items[0])
                                {
                                    inv2 = items[1];
                                    Console.WriteLine("Upgraded to Metal Sword!");
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);
                                    Thread.Sleep(1000);
                                }
                                else if (inv2 == items[1])
                                {
                                    inv2 = items[2];
                                    Console.WriteLine("Upgraded to Silver Sword!");
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);

                                    Thread.Sleep(1000);
                                }
                            }
                        }
                    }
                    if (invchoice == "3" && inv3 != "Empty")
                    {
                        if (item3used == false)
                        {
                            Console.WriteLine("Equip, Scrap, or Upgrade? (1,2,3)");
                            string itemchoice = Console.ReadLine();
                            if (itemchoice == "1")
                            {
                                item3used = true;
                                Console.WriteLine("Equipped");
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "2")
                            {
                                if (inv3 == items[0])
                                {
                                    Console.WriteLine(scrapamount[0]);
                                    scrap += scrapamount[0];
                                    gold += goldamount[0];
                                }
                                if (inv3 == items[1])
                                {
                                    Console.WriteLine(scrapamount[1]);
                                    scrap += scrapamount[1];
                                    gold += goldamount[1];
                                }
                                if (inv3 == items[2])
                                {
                                    Console.WriteLine(scrapamount[2]);
                                    scrap += scrapamount[2];
                                    gold += goldamount[2];
                                }
                                Console.WriteLine("Scrapped");
                                Console.WriteLine("Scrap: " + scrap);
                                Console.WriteLine("Gold: " + gold);
                                item3used = false;
                                inv3 = "Empty";
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "3")
                            {
                                if (inv3 == items[0])
                                {
                                    if (gold >= scrapcost[0] && scrap >= goldcost[0])
                                    {
                                        Console.WriteLine("Scrap Cost: " + scrapcost[0]);
                                        Console.WriteLine("Gold Cost: " + goldcost[0]);

                                        Thread.Sleep(1000);
                                    }

                                }
                                if (inv3 == items[1])
                                {
                                    if (gold >= scrapcost[1] && scrap >= goldcost[1])
                                    {
                                        Console.WriteLine("Scrap Cost: " + scrapcost[1]);
                                        Console.WriteLine("Gold Cost: " + goldcost[1]);

                                        Thread.Sleep(1000);
                                    }

                                }
                                if (inv3 == items[2])
                                {
                                    if (gold >= scrapcost[2] && scrap >= goldcost[2])
                                    {
                                        Console.WriteLine("Scrap Cost: " + scrapcost[2]);
                                        Console.WriteLine("Gold Cost: " + goldcost[2]);
                                        Thread.Sleep(1000);
                                    }

                                }
                                if (inv3 == items[0] && scrap >= scrapcost[0] && gold >= goldcost[0])
                                {
                                    inv3 = items[1];
                                    Console.WriteLine("Upgraded to Metal Sword!");
                                    scrap -= scrapcost[0];
                                    gold -= goldcost[0];
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);
                                    Thread.Sleep(1000);
                                }
                                else if (inv3 == items[1] && scrap >= scrapcost[1] && gold >= goldcost[1])
                                {
                                    inv3 = items[2];
                                    Console.WriteLine("Upgraded to Silver Sword!");
                                    scrap -= scrapcost[1];
                                    gold -= goldcost[1];
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);
                                    Thread.Sleep(1000);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Unequip, Scrap, or Upgrade? (1,2,3)");
                            string itemchoice = Console.ReadLine();
                            if (itemchoice == "1")
                            {
                                item3used = false;
                                Console.WriteLine("Unequipped");
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "2")
                            {

                                if (inv3 == items[0])
                                {
                                    scrap += scrapamount[0];
                                    gold += goldamount[0];
                                }
                                if (inv3 == items[1])
                                {
                                    scrap += scrapamount[1];
                                    gold += goldamount[1];
                                }
                                if (inv3 == items[2])
                                {
                                    scrap += scrapamount[2];
                                    gold += goldamount[2];
                                }
                                Console.WriteLine("Scrapped");
                                Console.WriteLine("Scrap: " + scrap);
                                Console.WriteLine("Gold: " + gold);
                                item3used = false;
                                inv3 = "Empty";
                                Thread.Sleep(1000);
                            }
                            if (itemchoice == "3")
                            {
                                if (inv3 == items[0])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[0]);
                                    Console.WriteLine("Gold Cost: " + goldcost[0]);
                                    scrap -= scrapcost[0];
                                    gold -= goldcost[0];
                                    Thread.Sleep(1000);
                                }
                                if (inv3 == items[1])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[1]);
                                    Console.WriteLine("Gold Cost: " + goldcost[1]);
                                    scrap -= scrapcost[1];
                                    gold -= goldcost[1];
                                    Thread.Sleep(1000);
                                }
                                if (inv3 == items[2])
                                {
                                    Console.WriteLine("Scrap Cost: " + scrapcost[2]);
                                    Console.WriteLine("Gold Cost: " + goldcost[2]);
                                    scrap -= scrapcost[2];
                                    gold -= goldcost[2];
                                    Thread.Sleep(1000);
                                }
                                if (inv3 == items[0])
                                {
                                    inv3 = items[1];
                                    Console.WriteLine("Upgraded to Metal Sword!");
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);
                                    Thread.Sleep(1000);
                                }
                                else if (inv3 == items[1])
                                {
                                    inv3 = items[2];
                                    Console.WriteLine("Upgraded to Silver Sword!");
                                    Console.WriteLine("Scrap: " + scrap);
                                    Console.WriteLine("Gold: " + gold);

                                    Thread.Sleep(1000);
                                }
                            }
                        }
                    }
                }
                else  if (opt1.Contains("move"))
                {
                    Console.Clear();
                    if (opt1.Contains("up")) 
                    {
                        
                    }
                    else if (opt1.Contains("up"))
                    {

                    }
                    else if (opt1.Contains("up"))
                    {

                    }
                    if (opt1.Contains("up"))
                    {

                    }
                } 
                if (opt1 == "items")
                {
                    Console.Clear();
                    Console.WriteLine("Wooden Sword                       Metal Sword                 Silver Sword");
                    Console.WriteLine("Scrap Sell Amount: " + scrapamount[0] + "         Scrap Sell Amount " + scrapamount[1] + "          Scrap Sell Amount " + scrapamount[2]);
                    Console.WriteLine("Gold Sell Amount: " + goldamount[0] + "           Gold Sell Amount " + goldamount[1] + "           Gold Sell Amount " + goldamount[2]);
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Scrap Buy Amount: " + scrapcost[0] + "          Scrap Buy Amount " + scrapcost[1] + "           Scrap Buy Amount " + scrapcost[2]);
                    Console.WriteLine("Gold Buy Amount: " + goldcost[0] + "           Gold Buy Amount " + goldcost[1] + "            Gold Buy Amount " + goldcost[2]);
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Press any button to exit item screen");
                    Console.ReadLine();
                }
                if (opt1 == "exit")
                {
                    run = false;
                }
            }
        }
    }
}
