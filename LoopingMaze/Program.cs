using System.Text;
namespace LoopingMaze;
internal class Program
{
    static void Main(string[] args)
    {
       
        int room = 1;

        do
        {
            Console.Clear();
            Console.WriteLine("Room: " + room);
            Console.WriteLine("Welcome to my maze, WASD to move.");
            char answer = Convert.ToChar(Console.ReadLine());

            if (room == 1)
            {
                room = room1(answer, room);
            }
            else if (room == 2)
            { 

                room = room2(answer, room);
            }
            else if (room == 3)
            {
                room = room3(answer, room);
            }
            else if (room == 4)
            {
                room = room4(answer, room);
            }
            else if (room == 5)
            {
                room = room5(answer, room);
            }
            else if (room == 6)
            {
                room = room6(answer, room);
            }
            else if (room == 7)
            {
                room = room7(answer, room);
            }
            else if (room == 8)
            {
                room = room8(answer, room);
            }
            else if (room == 9)
            {
                room = room9(answer, room);
            }
            else if (room == 10)
            {
                room = room10(answer, room);
            }
            else if (room == 11)
            {
                room = room11(answer, room);
            }
        } while (room != 12);
        Console.WriteLine("You win!");

    }
    static int room1(char answer, int room)
    {
        if (answer == 'd')
        {
            room = 2;
        }
        if (answer == 's')
        {
            room = 4;
        }
        if (answer == 'e')
        {
            room = 12;
        }
        return room;
    }
    static int room2(char answer, int room)
    {
        if (answer == 's')
        {
            room = 5;
        }
        if (answer == 'd')
        {
            room = 3;
        }
        if (answer == 'a')
        {
            room = 1;
        }
        return room;
    }
    static int room3(char answer, int room)
    {
        if (answer == 'a')
        {
            room = 2;
        }
        return room;
    }
    static int room4(char answer, int room)
    {
        if (answer == 'w')
        {
            room = 1;
        }
        if (answer == 'd')
        {
            room = 5;
        }
        if (answer == 's')
        {
            room = 7;
        }
        return room;
    }
    static int room5(char answer, int room)
    {
        if (answer == 'w')
        {
            room = 2;
        }
        if (answer == 'd')
        {
            room = 6;
        }
        if (answer == 'a')
        {
            room = 4;
        }
        return room;
    }
    static int room6(char answer, int room)
    {
        room = 5;
        return room;
    }
    static int room7(char answer, int room)
    {
        room = 8;
        return room;
    }
    static int room8(char answer, int room)
    {
        if (answer  == 'd')
        {
            room = 9;
        }
        if (answer == 's')
        {
            room = 11;
        }
        return room;
    }
    static int room9(char answer, int room)
    {
        if (answer == 'a')
        {
            room = 8;
        }
        return room;
    }
    static int room10(char answer, int room)
    {
        if (answer == 'd')
        {
            room = 11;
        }
        return room;
    }
    static int room11(char answer, int room)
    {
        if (answer == 'd')
        {
            room = 12;
        }
        if (answer == 'w')
        {
            room = 8;
        }
        if (answer == 'a')
        {
            room = 11;
        }
        return room;
    }
}
    
