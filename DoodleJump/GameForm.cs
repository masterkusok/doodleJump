using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoodleJump
{
    public partial class Form1 : Form
    {

        Bitmap bitmap;
        mainHero Doodle;
        Bullet bullet;
        Brick[] Bricks = new Brick[20];
        Cloud[] Clouds = new Cloud[20];

        int score;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(gameWindow.Width, gameWindow.Height);
            timer1.Interval = 1;
            KeyPreview = true;
          
        }
        int shootin_cntr = 0;
        bool shot;
        string name = "LMAOOOOOOOOOOOOOOOOOOOOOOOOOOO!@#!@#";
        private void gameWindow_Click(object sender, EventArgs e)
        {
            Doodle.shooting = true;
            shootin_cntr = 10;
            bullet = new Bullet(Doodle);
            shot = true;
            bullet.shooting_bullet = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bitmap);
            int CursorX = Cursor.Position.X;
            if (CursorX < 450 && CursorX > 400)
            {
                Doodle.left = true;
                Doodle.right = false;
                Doodle.x -= 1;
            }
            else if (CursorX < 400 && CursorX > 300)
            {
                Doodle.left = true;
                Doodle.right = false;
                Doodle.x -= 5;
            }
            else if (CursorX < 300)
            {
                Doodle.left = true;
                Doodle.right = false;
                Doodle.x -= 8;
            }
            else if (CursorX > 450 && CursorX < 500)
            {
                Doodle.left = false;
                Doodle.right = true;
                Doodle.x += 1;
            }
            else if (CursorX > 500 && CursorX < 600)
            {
                Doodle.left = false;
                Doodle.right = true;
                Doodle.x += 5;
            }
            else if (CursorX > 600)
            {
                Doodle.left = false;
                Doodle.right = true;
                Doodle.x += 8;
            }

            if(Doodle.x < 0)
            {
                Doodle.x = gameWindow.Width - Doodle.width;
            }
            if(Doodle.x > gameWindow.Width)
            {
                Doodle.x = 0;
            }

            if (Doodle.y < 100)
            {
                score++;
                Doodle.y += 10;
                
                for (int i = 0; i < Bricks.Length; i++)
                {
                    Bricks[i].y += 10;

                    if (Bricks[i].y > 520)
                    {
                        if (i == 0)
                        {
                            Bricks[i].moveBrick(Bricks[Bricks.Length - 1]);
                        }
                        else
                        {
                            Bricks[i].moveBrick(Bricks[i - 1]);
                        }
                    }
                }
                for (int i = 0; i < Clouds.Length; i++)
                {
                    Clouds[i].y += 10;

                    if (Clouds[i].y > 520)
                    {
                        if (i == 0)
                        {
                            Clouds[i].moveBrick(Clouds[Clouds.Length - 1]);
                        }
                        else
                        {
                            Clouds[i].moveBrick(Clouds[i - 1]);
                        }
                    }

                }

                }
                if (Doodle.y > 480)
            {
                timer1.Stop();
                MessageBox.Show("геймовер, счёт" + score.ToString());
                startBtn.Show();
                startBtn.Text = "CНОВА";
                menuBtn.Show();
                using (StreamReader rf = new StreamReader("rec.txt")) {
                    int newRec = int.Parse(rf.ReadLine());
                    if (newRec < score){
                        rf.Close();

                        using (StreamWriter wf = new StreamWriter("rec.txt"))
                        {
                            wf.WriteLine(score);
                            wf.WriteLine(name);
                        }
                    }
                }

            }
            
            g.Clear(Color.LightBlue);

            for (int i = 0; i < Clouds.Length; i++)
            {
                g.DrawImage(Image.FromFile("images/cloud.png"), Clouds[i].x, Clouds[i].y);
            }

            for (int i = 0; i < Bricks.Length; i++)
            {
                if (Bricks[i].type == 2)
                {
                    g.DrawImage(Image.FromFile("images/brick_2.png"), Bricks[i].x, Bricks[i].y);
                }
                else
                {
                    g.DrawImage(Image.FromFile("images/brick.png"), Bricks[i].x, Bricks[i].y);
                }
            }

            if (Doodle.left)
            {
                
                if (Doodle.shooting)
                {
                    g.DrawImage(Image.FromFile("images/hero_shooting.png"), Doodle.x, Doodle.y);
                }
                else
                {
                    g.DrawImage(Image.FromFile("images/hero.png"), Doodle.x, Doodle.y);
                }
            }
            else if (Doodle.right)
            {
                if (Doodle.shooting)
                {
                    g.DrawImage(Image.FromFile("images/hero_shooting_r.png"), Doodle.x, Doodle.y);
                }
                else
                {
                    g.DrawImage(Image.FromFile("images/hero_right.png"), Doodle.x, Doodle.y);
                }
            }

            if (shot)
            {
                bullet.shoot(Doodle);
            }

            if (shootin_cntr != 0)
            {
                shootin_cntr--;
            }
            else
            {
                Doodle.shooting = false;
            }
            Doodle.Jump(Bricks);
            
            if (Doodle.shooting)
            {
                g.DrawImage(Image.FromFile("images/bullet.png"), bullet.x, bullet.y);
            }
            label1.Text = "счёт-" + score.ToString();  
            gameWindow.Image = bitmap;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (name != "LMAOOOOOOOOOOOOOOOOOOOOOOOOOOO!@#!@#")
            {
                menuBtn.Hide();
                startBtn.Hide();
                timer1.Enabled = true;
                Doodle = new mainHero();
                Doodle.x = (gameWindow.Width / 2) - Doodle.width;
                Doodle.y = (gameWindow.Height / 2) - (Doodle.height * 2);
                score = 0;

                for (int i = 0; i < Bricks.Length; i++)
                {
                    Bricks[i] = new Brick();
                }
                for (int i = 0; i < Clouds.Length; i++)
                {
                    Clouds[i] = new Cloud();
                }

                Bricks[0].y = Doodle.y + 30;
                Bricks[0].x = Doodle.x;

                for (int i = 1; i < Bricks.Length; i++)
                {
                    Bricks[i].moveBrick(Bricks[i - 1]);
                }
                for (int i = 1; i < Clouds.Length; i++)
                {
                    Clouds[i].moveBrick(Clouds[i - 1]);
                }
            }
            else
            {
                MessageBox.Show("Сначала имя введи дурачок");
            }
        }
        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void gameWindow_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            menuForm menu = new menuForm();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
