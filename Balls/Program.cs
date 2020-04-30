using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {

            GameBalls game = new GameBalls();
            
            game.Play();
            Console.WriteLine($"{game.result} was Deleted");
            Console.WriteLine($"{game.list.Count} Stay");
            Thread.Sleep(2000);
            Console.ReadKey();
            game.Show();
            Console.ReadKey();
                
        }
    }
}
