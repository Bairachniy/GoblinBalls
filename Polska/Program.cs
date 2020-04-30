using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polska
{
    class Program
    {

        static void Main(string[] args)
        {
            MyPolska polska = new MyPolska();
            Console.WriteLine("Inset expression");
            try
            {
                string a = Console.ReadLine();
                char[] str = a.ToCharArray();
                Console.WriteLine( polska.Result(str));

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
