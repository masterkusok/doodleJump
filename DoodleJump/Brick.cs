using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DoodleJump
{
    class Brick
    {
       public int width = 50, height = 15, x, y, type;
       //type 1 - basic, 2 - higher jump, 3 - with monster

        public Brick()
        {
            Thread.Sleep(1);
            Random rand = new Random(DateTime.Now.Millisecond);
            x = rand.Next(0, 630);
        }     

       public virtual void moveBrick(Brick last)
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
            Thread.Sleep(1);
            int newRand = rand.Next(0, 10);
            switch(newRand)
            {
                case 1:
                    {
                        this.type = 3;
                        break;
                    }
                case 2:
                    {
                        this.type = 2;
                        break;
                    }
                default: 
                    {
                        this.type = 1;
                        break;
                    }
            }
            
       }


    }
}
