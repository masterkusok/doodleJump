using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DoodleJump
{
    class Cloud : Brick
    {
        
        public Cloud()
        {
            Thread.Sleep(1);
            Random rand = new Random(DateTime.Now.Millisecond);
            x = rand.Next(0, 630);
            y = rand.Next(0, 500);
            width = 35;
            height = 15;
        } 

        public void moveBrick(Cloud last)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(1);
            this.y = last.y - rand.Next(40, 130);
            int some_rand = rand.Next(0, 1);
            switch (some_rand)
            {
                case 0:
                    {
                        if (last.x > 220)
                        {
                            this.x = last.x - rand.Next(0, 220);
                            break;
                        }
                        else
                        {
                            this.x = last.x + rand.Next(0, 220);
                            break;

                        }
                    }
                case 1:
                    {
                        if (last.x < 430)
                        {
                            this.x = last.x + rand.Next(0, 220);
                            break;
                        }
                        else
                        {
                            this.x = last.x - rand.Next(0, 220);
                            break;
                        }
                    }
            }
        }
    }
}
