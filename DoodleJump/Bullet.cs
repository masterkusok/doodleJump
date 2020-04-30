using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoodleJump
{
    class Bullet
    {
        public int x, y, width = 5, height = 5, speed = 20;
        public bool shooting_bullet;
        public Bullet(mainHero hero)
        {
            startPosition(hero);
        }
        public void startPosition(mainHero hero)
        {
            this.x = hero.x + (hero.width / 2);
            this.y = hero.y;
            this.shooting_bullet = false;
        }
        public void shoot(mainHero hero)
        {
            if (shooting_bullet)
            {
                this.y -= speed;
                if(this.y < -1500)
                {
                    startPosition(hero);
                }
            }
        }
    }
}
