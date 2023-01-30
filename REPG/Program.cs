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
            int dmin = 1;
            int dmax = 5;
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
            int[] damagelist = { 2, 5, 10 };
            string[] room = { };
            int roomnum = 0;

            string inv1 = "Wooden Sword";
            string inv2 = "Wooden Sword";
            string inv3 = "Wooden Sword";
            int scrap = 0;
            int gold = 0;
            int level = 99;
            int xp = 0;
            bool item1used = false;
            bool item2used = false;
            bool item3used = false;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("inv for Inventory.");
                Console.WriteLine("move (forward or backward) to move a direction.");
                Console.WriteLine("items to view descriptions to find costs and amounts for items.");
                Console.WriteLine("exit to exit the game.");
                if (xp == 100)
                {
                    xp = 0;
                    level += 1;
                }
                string opt1 = Console.ReadLine();
                if (opt1 == "inv")
                {
                    Inventory(ref scrap, gold, health, damage, inv1, inv2, inv3, xp, level);
                    //Console.WriteLine("----------------");
                    //Console.WriteLine("Scrap: " + scrap);
                    //Console.WriteLine("Gold: " + gold);
                    //Console.WriteLine("Health: " + health);
                    //Console.WriteLine("Damage: " + damage);
                    //Console.WriteLine("Slot 1: " + inv1);
                    //Console.WriteLine("Slot 2: " + inv2);
                    //Console.WriteLine("Slot 3: " + inv3);
                    //Console.WriteLine("1, 2, 3, or exit to select item or quit inventory menu.");
                    //Console.WriteLine("----------------");
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
                                else if (inv2 == items[1] && scrap >= scrapcost[1] && gold >= goldcost[1])
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
                                else if (inv2 == items[1] && scrap >= scrapcost[1] && gold >= goldcost[1])
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
                    }
                }
                else  if (opt1.Contains("move"))
                {
                    Console.Clear();
                    Random rand = new Random();
                    if (opt1.Contains("forward"))
                    {
                        bool attacking = true;
                        enemyhealth = rand.Next(5,10);
                        enemydamage = rand.Next(1, 5);

                        Console.WriteLine("You moved forward. You see an enemy with " + enemyhealth + " health and " + enemydamage + " damage.");
                        Console.WriteLine("Attack or flee? 1,2");
                        string decision1 = Console.ReadLine();
                        if (decision1 == "1") 
                        {
                            while (attacking)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (inv1 == items[i])
                                    {
                                        Combat(ref enemyhealth, damagelist, i, damage, ref scrap, ref gold, ref attacking, ref health, enemydamage, xp);
                                        //enemyhealth -= (damagelist[i] + damage);
                                        //Console.WriteLine("You damaged the enemy for " + (damagelist[i] + damage) + " health.");
                                        //Console.WriteLine("Enemy health: " + enemyhealth);
                                        //scrap += 1;
                                        //gold += 1;
                                        //Thread.Sleep(2000);
                                        //if (enemyhealth <= 0)
                                        //{
                                        //    attacking = false;
                                        //    break;
                                        //}
                                        //Thread.Sleep(2500);
                                        //health = (health - enemydamage);
                                        //Console.WriteLine("The enemy damaged you for " + enemydamage);
                                        //Console.WriteLine("Your health: " + health);
                                        //if (health <= 0)
                                        //{
                                        //    attacking = false;
                                        //    break;
                                        //}
                                        //Console.WriteLine("Do you want to flee? 1,2");
                                        //string ans = Console.ReadLine();
                                        //if (ans == "1")
                                        //{
                                        //    attacking = false;
                                        //} else {
                                        //    Console.WriteLine("Good!");
                                        //}
                                    }
                                }
                            }
                        }
                        else if (decision1 == "2")
                        {
                        Console.WriteLine("You ran.");
                        }
                    }
                    else if (opt1.Contains("backward"))
                    {
                        Console.WriteLine("You moved backwards, and there's not much in the room.");
                    }
                } 
                if (opt1 == "items")
                {
                    Console.Clear();
                    Console.WriteLine("Wooden Sword                     Metal Sword                 Silver Sword");
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
        static void Inventory(ref int scrap, int gold, int health, int damage, string inv1, string inv2, string inv3, int xp, int level)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Scrap: " + scrap);
            Console.WriteLine("Gold: " + gold);
            Console.WriteLine("XP: " + xp);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Slot 1: " + inv1);
            Console.WriteLine("Slot 2: " + inv2);
            Console.WriteLine("Slot 3: " + inv3);
            Console.WriteLine("1, 2, 3, or exit to select item or quit inventory menu.");
            Console.WriteLine("----------------");
        }
        static void Combat(ref int enemyhealth, int[] damagelist, int i, int damage, ref int scrap, ref int gold, ref bool attacking, ref int health, int enemydamage, int xp)
        {
            Console.WriteLine("Scrap: " + scrap);
            Console.WriteLine("Gold: " + gold);
            enemyhealth -= (damagelist[i] + damage);
            Console.WriteLine("You damaged the enemy for " + (damagelist[i] + damage) + " health.");
            Console.WriteLine("Enemy health: " + enemyhealth);
            scrap += 1;
            gold += 1;
            xp += 15;
            Thread.Sleep(2000);
            if (enemyhealth <= 0)
            {
                attacking = false;
                return;
            }
            Thread.Sleep(2500);
            health = (health - enemydamage);
            Console.WriteLine("The enemy damaged you for " + enemydamage);
            Console.WriteLine("Your health: " + health);
            if (health <= 0)
            {
                attacking = false;
                return;
            }
            Console.WriteLine("Do you want to flee? 1,2");
            string ans = Console.ReadLine();
            if (ans == "1")
            {
                attacking = false;
            }
            else
            {
                Console.WriteLine("Good!");
            }
        }
    }
}
