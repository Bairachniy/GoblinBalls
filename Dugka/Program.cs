using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dugka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your expression");

            string str = Convert.ToString(Console.ReadLine());
            char[] strchar = str.ToCharArray();
            Console.WriteLine( CheckDugki.Check(strchar));
            Console.ReadKey();


        }
    }
}
