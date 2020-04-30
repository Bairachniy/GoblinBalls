using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackMy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mas = new string[5] { "Masha", "Rita", "Petya", "Lesha", "Vanya" };
            Queue<string> que = new Queue<string>();
            var stk = new Stack<string>(mas);
            foreach (var item in stk)
                que.Enqueue(item);
            ConsoleKeyInfo btn;
            do
            {
                Console.WriteLine($"Your data: {que.Dequeue()}");
            link1:
                Console.Write("To continue show Queue press Enter, to quite press Space: ");
                btn = Console.ReadKey();
                if (que.Count == 0)
                {
                    Console.WriteLine("Queue is empty");
                    break;
                }
                else if (btn.Key != ConsoleKey.Enter && btn.Key != ConsoleKey.Spacebar)
                {
                    Console.WriteLine();
                    goto link1;
                }
                Console.WriteLine();
            } while (btn.Key != ConsoleKey.Spacebar);
        }
    }
}
