using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoodleJump
{
    class mainHero
    {
        public int height = 50, width = 50, x, y, jump_count = 20, jump_increase = 9;
        public bool left, right, shooting;

        public mainHero()
        {
            left = true;
            right = false;
            shooting = false;
        }

        public void Jump(Brick[] arr)
        {
            if (this.jump_count > 0)
            {
                this.y -= (this.jump_count * this.jump_count) / jump_increase;
                this.jump_count--;
            }
            else
            {
                if (jump_count < -3)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if ((this.x > arr[i].x - this.width) && (this.x < arr[i].x + this.width) &&
                            (this.y + this.height >= arr[i].y) && (this.y + this.height <= arr[i].y + arr[i].height)
                          /* (this.y <= arr[i].y + this.height) && (this.y >= arr[i].y - this.height)*/)
                        {
                            if (arr[i].type == 2)
                            {
                                jump_increase = 5;
                            }
                            else
                            {
                                jump_increase = 9;
                            }
                            jump_count = 15;
                        }
                    }
                }
                if (this.jump_count != 15 )
                {
                    this.y += (this.jump_count * this.jump_count) / 9;
                    this.jump_count--;
                }
            }
        }

    }
}
