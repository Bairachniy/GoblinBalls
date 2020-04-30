using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dugka
{
   public class CheckDugki
    {
        
        public static string Check(char [] a)
        {
            
            Stack<char> stack = new Stack<char>();
            
            for (int i = 0; i < a.Length; i++)
            {
                
                if(a[i]=='('|| a[i] == '{' || a[i] == '[' || a[i] == '<')
                {
                    stack.Push(a[i]);
                    continue;
                }
                if ((a[i] == ')' || a[i] == '}' || a[i] == ']' || a[i] == '>') && stack.Count == 0)
                { return "Something wrong"; }
                else
                {
                    switch (a[i])
                    {
                        case ')':
                            {
                                if (stack.Peek() == '(')
                                    stack.Pop();
                                break;
                            }
                        case '}':
                            {
                                if (stack.Peek() == '{')
                                    stack.Pop();
                                break;
                            }
                        case '>':
                            {
                                if (stack.Peek() == '<')
                                    stack.Pop();
                                break;
                            }
                        case ']':
                            {
                                if (stack.Peek() == '[')
                                    stack.Pop();
                                break;
                            }

                    }
                }
                   
                
            }
            if (stack.Count == 0)
            {
                return "Allright";
            }
            else
                return "Something wrong";

        }

    }
}
