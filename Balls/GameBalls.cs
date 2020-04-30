using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Balls
{
   public  class GameBalls
    {
        Random rnd = new Random();
       public List<int> list = new List<int>();
        int count = 0;
        int count2;
       public int result = 0;
        
        int temp ;
        public GameBalls()
        {
            for (int i = 0; i < 100000; i++)
            {
                list.Add(rnd.Next(10));
            }
        }
        public void Show()
        {
            foreach(var i in list)
            {
                if (count == 50)
                { Console.WriteLine(); }
                switch (i)
                {
                    case 0:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.Write(i);
                            count++;
                            break;
                        }
                    case 1:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.Write(i);
                            count++;
                            break;
                        }
                    case 2:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Write(i);
                            count++;
                            break;
                        }
                    case 3:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.Write(i);
                            count++;
                            break;
                        }
                    case 4:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write(i);
                            count++;
                            break;
                        }
                    case 5:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Write(i);
                            count++;
                            break;
                        }
                    case 6:
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write(i);
                            count++;
                            break;
                        }
                    case 7:
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(i);
                            count++;
                            break;
                        }
                    case 8:
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(i);
                            count++;
                            break;
                        }
                    case 9:
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(i);
                            count++;
                            break;
                        }


                }


            }
        }

        public void Play()
        {
            for (int i = 1; i < list.Count-1; i++)
            {
                count2 = 1;
                temp = i-1;
                while(list[temp]==list[temp+1])
                { temp++; count2++;          }
                if (count2 > 2)
                {
                    for (int j = i-1; j < temp; j++)
                    {
                        list.RemoveAt(j);
                        result++;
                    }
                    Console.WriteLine($"{count2} Balls Deleted by number {list[i]}");
                   
                }
                
            }

        }
    }
}
