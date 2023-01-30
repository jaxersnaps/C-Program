/*Jaxson Cuttitte, Concession Stand*/
namespace concessionstand
{
    internal class Program
    {
        enum Sizes { None, Small, Medium, Large, Jumbo };
        static void Main(string[] args)
        {
            
            Console.WriteLine("Concession Stand");
            Sizes drink = Sizes.None, popcorn = Sizes.None;
            double total = 0;
            double tax = 0;
            bool order = true;
            string answer = "";
            Console.WriteLine("Welcome to the concession stand.");
            Console.WriteLine("We have drinks and popcorn available.");
            Console.WriteLine("Drinks and popcorn come in Small, Medium, Large, and Jumbo sizes.");
            Console.WriteLine("Choose your drink size.");
            while (order)
            {
                Console.WriteLine("\t0. None\n\t1. Small $1.50\n\t2. Medium $2.50\n\t3. Large $4.00\n\t4. Jumbo $6.00");
                drink = (Sizes)Convert.ToInt32(Console.ReadLine());
                Console.Write(">> ");

                switch (drink)
                {
                    case Sizes.None:
                        Console.WriteLine("You have chosen not to get a drink.");
                        break;
                    case Sizes.Small:
                        total += 1.5;
                        break;
                    case Sizes.Medium:
                        total += 2.5;
                        break;
                    case Sizes.Large:
                        total += 4.0;
                        break;
                    case Sizes.Jumbo:
                        total += 6.0;
                        break;
                }
                Console.WriteLine("\t0. None\n\t1. Small $2.00\n\t2. Medium $4.00\n\t3. Large $6.00\n\t4. Jumbo $8.00");
                popcorn = (Sizes)Convert.ToInt32(Console.ReadLine());
                Console.Write(">> ");

                switch (popcorn)
                {
                    case Sizes.None:
                        Console.WriteLine("You have chosen not to get popcorn.");
                        break;
                    case Sizes.Small:
                        total += 2.0;
                        break;
                    case Sizes.Medium:
                        total += 4.0;
                        break;
                    case Sizes.Large:
                        total += 6.0;
                        break;
                    case Sizes.Jumbo:
                        total += 8.0;
                        break;
                }
                Console.WriteLine("Do you want to order again? Y,N");
                answer = Console.ReadLine();
                if (answer == "Y")
                {
                    order = true;
                }
                if (answer == "N")
                {
                    order = false;
                } else
                {
                    Console.WriteLine("Not an answer.");
                }
            }
            
            Console.WriteLine("Price: {0,10:C2}", total);
            tax = taxchecker(total, tax);
            Console.WriteLine("Tax: {0,10:C2}", tax);
            Console.WriteLine("Total: {0,10:C2}", tax += total);
        }
        static double taxchecker(double total, double tax)
        {
            tax = total * (total / 100);
            return tax;
        }

    }
}
