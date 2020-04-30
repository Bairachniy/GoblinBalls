using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblin
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo btn;
            MyQueue game = new MyQueue();
            game.gbl.Enqueue(new Goblin("Stepashka", 0));
            game.gbl.Enqueue(new Goblin("Grom", 1));
            game.gbl.Enqueue(new Goblin("Pisiashka", 0));
            game.gbl.Enqueue(new Goblin("Orkonaft", 1));
            game.gbl.Enqueue(new Goblin("Alkash", 1));
            game.gbl.Enqueue(new Goblin("Embrion", 0));
            game.gbl.Enqueue(new Goblin("Inoplanetianin", 1));
            do
            {
            link1:
                Console.Write("To continue show Queue press Enter, to quite press Space: ");
                btn = Console.ReadKey();
                if (game.gbl.Count == 0)
                    break;
                else if (btn.Key != ConsoleKey.Enter && btn.Key != ConsoleKey.Spacebar)
                {
                    Console.WriteLine();
                    goto link1;
                }
                else if (btn.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(game.MyEnqueue(game.GoblinCreator()));
                    Console.WriteLine();
                    foreach (var item in game.gbl)
                    {
                        Console.WriteLine(item.Name);
                    }
                    Console.WriteLine();
                }
            } while (btn.Key != ConsoleKey.Spacebar);


        }
        
    }
}
