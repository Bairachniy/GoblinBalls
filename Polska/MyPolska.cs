using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polska
{
    public class MyPolska
    {
        Stack<int> pol = new Stack<int>();

        public  int Result(char[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (Int32.TryParse(a[i].ToString(), out int res))
                {
                    pol.Push(res);
                }
                if ((a[i] == '+' || a[i] == '-' || a[i] == '*' || a[i] == '/') && pol.Count > 1)
                {
                    try
                    {
                        switch (a[i])
                        {
                            case '+':
                                {
                                    pol.Push(pol.Pop() + pol.Pop());
                                    break;
                                }
                            case '-':
                                {
                                    pol.Push(pol.Pop() - pol.Pop());
                                    break;
                                }
                            case '/':
                                {
                                    int temp = pol.Pop();
                                    if (pol.Peek() == 0)
                                    {
                                        throw new DivideByZeroException("Connod dividing by zero");
                                    }

                                    pol.Push(temp / pol.Pop());
                                    break;
                                }
                            case '*':
                                {
                                    pol.Push(pol.Pop() * pol.Pop());
                                    break;
                                }


                        }

                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("You try divide by zero");
                    }
                }
            }
            if (pol.Count == 1)
                return pol.Peek();
            else
                throw new Exception("Your expression is not valid");

        }
    }
}


    

