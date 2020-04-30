using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblin
{
    class MyQueue
    {
        public Queue<Goblin> gbl = new Queue<Goblin>();


        public Goblin GoblinCreator()
        {
            Random rnd = new Random();
            int k = rnd.Next(1, 5);
            switch (k)
            {
                case 1:
                    return new Goblin("Saveliy", 0);
                case 2:
                    return new Goblin("Inokentiy", 1);
                case 3:
                    return new Goblin("Briginton", 0);
                case 4:
                    return new Goblin("Ororo", 1);
                default:
                    return new Goblin("OMG", 0);
            }
        }
        public Goblin MyEnqueue(Goblin goblin)
        {
            if (gbl.Count == 0)
                gbl.Enqueue(goblin);


            else if (goblin.Priority == 0 && gbl.Count > 0)
                gbl.Enqueue(goblin);

            else
            {
                int temp = gbl.Count;
                for (int i = 0; i < gbl.Count; i++)
                {

                    if (temp % 2 != 0)
                    {
                        if (i == gbl.Count / 2 + 2)
                        {
                            gbl.Enqueue(goblin);
                            temp = 1;
                        }
                        else
                        {
                            gbl.Enqueue(gbl.Peek());
                            gbl.Dequeue();
                            temp = 1;
                        }
                    }
                    if (temp % 2 == 0)
                    {
                        if (i == gbl.Count / 2 + 1)
                        {
                            gbl.Enqueue(goblin);
                            continue;
                        }
                        else
                        {
                            gbl.Enqueue(gbl.Peek());
                            gbl.Dequeue();
                        }
                    }

                }
            }
            return gbl.Dequeue();
        }

    }

    public class Goblin
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public Goblin(string Name, int Priority)
        {
            this.Name = Name;
            this.Priority = Priority;
        }

        public override string ToString()
        {
            return $"Hello Shaman, my Name {Name}, i'm glad to see you! My Priority is {Priority}";
        }
    }
}
