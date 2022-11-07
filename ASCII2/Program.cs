/*Ascii Art Assignment, Thomas O'Dell and Jaxson Cuttitte */
namespace ASCII2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What Ascii Art do you want to display? House, Forest, Dungeon? (1,2,3)");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
              
                case 1:
                    Console.WriteLine("  ____||____");
                    Console.WriteLine(" ///////////\\");
                    Console.WriteLine("///////////  \\");
                    Console.WriteLine("|    _    |  |");
                    Console.WriteLine("|[] | | []|[]|");
                    Console.WriteLine("|   | |   |  |");
                    
                    break;
                case 2:
                    Console.WriteLine(@" (              ````                                            ");
                    Console.WriteLine(@";`             ;;                                               ");
                    Console.WriteLine(@" ;;  -""-.   ;;                 -;'  -.                         ");
                    Console.WriteLine(@"   ""     ``                      `.   `.                       ");
                    Console.WriteLine(@"                                    ;    `                      ");
                    Console.WriteLine(@"           `;                  -          ;         -.        ;`");
                    Console.WriteLine(@"             `-  `.         .'`  .-'             .--`  ;     ;  ");
                    Console.WriteLine(@"              ;    `-.   ;    `-'             .;`     ;       `.");
                    Console.WriteLine(@"              .        ``                                       ");
                    Console.WriteLine("               `            .--------.             .'           ");
                    Console.WriteLine(@"             ...        .--'``````````'--.        ;.            ");
                    Console.WriteLine(@"            `      . .-' .``          ``. '-. .      `.         ");
                    Console.WriteLine(@"          ;-.;  .  .' .`                  `. '.  .    ;         ");
                    Console.WriteLine(@"              .' .' .`                      `. '. '.    .       ");
                    Console.WriteLine(@"_____/'.-..___________________________ mvn,, ___________________");
                    Console.WriteLine(@"                             )\\     nMmIEFooPTn                 ");
                    Console.WriteLine(@"                            ( (    Li1iiJl1ItTIjp               ");
                    Console.WriteLine(@"                             ) \\  i i_BP_LWmKK`  J  `           ");
                    Console.WriteLine(@"`                .          /  (   i1 LL 1I`L            .      ");
                    Console.WriteLine(@"             ..             \\   \\  i   X  Y o1                  ");
                    Console.WriteLine(@"                        .    )   )  `   l   p      ..           ");
                    Console.WriteLine(@";                           /   (,      l(@) l                ..");
                    Console.WriteLine(@"  q      ` .  '            (     \\.     i    p   R          .;  ");
                    Console.WriteLine(@"   \\  t            ;        )     \\`   j,.. ,.q,/Pqoj          `");
                    Console.WriteLine(@"    \\/            `       ./       \\`;     `'     `          .. ");
                    Console.WriteLine(@"  '-     \\;            -'.'    ;    \\ `                     `. `");
                    Console.WriteLine(@".--.`.; ,-.. ,.-, ;' `.-'       `    `.'.   .--.""-._        .; ");
                    Console.WriteLine(@"    `............---""     _.         )   (  =    /         `-");
                    Console.WriteLine(@" ~                                    /     `------'     .      ");
                    Console.WriteLine(@"                 ~                  ,  \\|//                    ");
                    Console.WriteLine(@"                ~           ~       ; `. ""                   ..");
                    Console.WriteLine(@"                                     `.  )     \\       .--");
                    break;
                case 3:

                    Console.WriteLine("================================");
                    Console.WriteLine("||     ||<(.)>||<(.)>||     || ");
                    Console.WriteLine("||    _||     ||     ||_    || ");
                    Console.WriteLine("||   (__D    *||*    C__)   || ");
                    Console.WriteLine("||   (__D     ||     C__)   ||");
                    Console.WriteLine("||   (__D    -||-    C__)   ||");
                    Console.WriteLine("||   (__D   / || \\  C__)   ||");
                    Console.WriteLine("||     ||     ||     ||     ||");
                    Console.WriteLine("================================" +
                        "ALL ART IS FROM ASCIIART.EU");
                    break;
            }
            
        }

    }
}