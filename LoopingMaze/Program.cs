using System.Text;
namespace LoopingMaze;
internal class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb1 = new StringBuilder("------------");
        StringBuilder sb2 = new StringBuilder("|   #   #   |");
        StringBuilder sb3 = new StringBuilder("--#---#------");
        StringBuilder sb4 = new StringBuilder("|   #   #   |");
        StringBuilder sb5 = new StringBuilder("--#----------");
        StringBuilder sb6 = new StringBuilder("|   #   #   |");
        StringBuilder sb7 = new StringBuilder("-------------");
        sb2[2] = '@';
        int room = 1;
        
        do
        {
            Console.Clear();
            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
            Console.WriteLine(sb3);
            Console.WriteLine(sb4);
            Console.WriteLine(sb5);
            Console.WriteLine(sb6);
            Console.WriteLine(sb7);
            Console.WriteLine("Room: " + room);
            Console.WriteLine("Welcome the my maze, WASD to move.");
            char answer = Convert.ToChar(Console.ReadLine());
            
            if (room == 1)
            {
                if (answer == 'd')
                {
                    room = 2;
                    sb2[6] = '@';
                    sb2[2] = ' ';
                }
                if (answer == 's')
                {
                    room = 4;
                    sb4[2] = '@';
                    sb2[2] = ' ';
                }
            }
            else if (room == 2)
            {
                if (answer == 's')
                {
                    room = 5;
                    sb4[6] = '@';
                    sb2[6] = ' ';
                }
                if (answer == 'd')
                {
                    room = 3;
                    sb2[10] = '@';
                    sb2[6] = ' ';
                }
                if (answer == 'a')
                {
                    room = 1;
                    sb2[2] = '@';
                    sb2[6] = ' ';
                }
            }
            else if (room == 3)
            {
                if (answer == 'a')
                {
                    sb2[6] = '@';
                    sb2[10] = ' ';
                    room = 2;
                }
            }
            else if (room == 4)
            {
                if (answer == 'w')
                {
                    sb2[2] = '@';
                    sb4[2] = ' ';
                    room = 1;
                }
                if (answer == 'd')
                {
                    room = 5;
                    sb4[6] = '@';
                    sb4[2] = ' ';
                }
                if (answer == 's')
                {
                    room = 7;
                    sb6[2] = '@';
                    sb4[2] = ' ';
                }
            }
            else if (room == 5)
            {
                if (answer == 'w')
                {
                    room = 2;
                    sb2[6] = '@';
                    sb4[6] = ' ';
                }
                if (answer == 'd')
                {
                    room = 6;
                    sb4[10] = '@';
                    sb4[6] = ' ';
                }
                if (answer == 'a')
                {
                    room = 4;
                    sb4[2] = '@';
                    sb4[6] = ' ';
                }
            }
            else if (room == 6)
            {
                if (answer == 'a')
                {
                    room = 5;
                    sb4[6] = '@';
                    sb4[10] = ' ';
                }
            }
            else if (room == 7)
            {
                if (answer == 'w')
                {
                    room = 4;
                    sb4[2] = '@';
                    sb6[2] = ' ';
                }
                if (answer == 'd')
                {
                    room = 8;
                    sb6[6] = '@';
                    sb6[2] = ' ';
                }
            }
            else if (room == 8)
            {
                if (answer == 'd')
                {
                    room = 9;
                    sb6[10] = '@';
                    sb6[6] = ' ';
                }
                if (answer == 'a')
                {
                    room = 7;
                    sb6[2] = '@';
                    sb6[6] = ' ';
                }
            }
        } while (room != 9);
        Console.WriteLine("You win!");
    }
}    
    
