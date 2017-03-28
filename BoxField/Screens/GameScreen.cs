using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BoxField
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;
        //used to draw boxes on screen
        public static SolidBrush boxBrush = new SolidBrush(Color.White);

        //List to hold a column of boxes
        List<Box> boxes = new List<Box>();

        //Box Values
        public int boxSize, boxSpeed, newBoxCounter, color, red, green, blue;

        //hero Character
        Box hero;
        int heroSpeed, heroColor;
        
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        
        /// <summary>
        /// Set initial game values here
        /// </summary>
        public void OnStart()
        {
            boxSize = 20;
            boxSpeed = 5;
            newBoxCounter = 0;

            Box b1 = new Box(200, -40, boxSize, boxSpeed);
            boxes.Add(b1);

            Box b2 = new Box(500, -40, boxSize, boxSpeed);
            boxes.Add(b2);

            //set hero values at start of game
            heroSpeed = 7;
            hero = new Box(this.Width / 2 - boxSize / 2, 400, boxSize, heroSpeed);

        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        //private void moveTimer_Tick(object sender, EventArgs e)
        //{
        //    int direction, x1, x2;

        //    Random randGen = new Random();
        //    direction = randGen.Next(1, 3);

        //    if (direction == 1)
        //    {
        //        x1 = x1 + 25;
        //    }
        //    if (direction == 2)
        //    {
        //        x1 = x1 - 25;
        //    }

        //    direction = 0;
        //}

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //update location of all boxes (drop down screen)
            foreach (Box b in boxes)
            {
                b.Move();
                //b.moveDirection(); HARD MODE! Only un-comment if you want a challenge!   
            }

            //add new box if it is time

            newBoxCounter++;

            if (newBoxCounter == 5)
            {
                Box b1 = new Box(200, -40, boxSize, boxSpeed);
                boxes.Add(b1);

                Box b2 = new Box(500, -40, boxSize, boxSpeed);
                boxes.Add(b2);
            }

            if (newBoxCounter == 8)
            {
                Random randGen = new Random();

                color = randGen.Next(1, 7);

                if (color == 1)
                {
                    red = 255;
                    blue = 255;
                    green = 0;
                }
                if (color == 2)
                {
                    red = 255;
                    blue = 0;
                    green = 0;
                }
                if (color == 3)
                {
                    red = 255;
                    blue = 80;
                    green = 0;
                }
                if (color == 4)
                {
                    red = 255;
                    blue = 195;
                    green = 0;
                }
                if (color == 5)
                {
                    red = 0;
                    blue = 255;
                    green = 0;
                }
                if (color == 6)
                {
                    red = 0;
                    blue = 0;
                    green = 255;
                }

                boxBrush.Color = Color.FromArgb(255, red, blue, green);

                newBoxCounter = 0;
            }

            if (boxes[0].y > this.Height) 
            {
                boxes.RemoveAt(0);
            }

            //move our hero
            if(leftArrowDown == true)
            {
                hero.Move("left");
            }

            if(rightArrowDown)
            {
                hero.Move("right");
            }

            //Check for collision between hero and boxes
            foreach (Box b in boxes)
            {
                //Boolean hasCollided = false;

                //hasCollided = hero.Collision(b);

                //if (hasCollided == true)
                //{
                //    gameLoop.Stop();
                //}
                if (hero.Collision(b))
                {
                    gameLoop.Stop();
                }
            }
         

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw boxes to screen

            foreach (Box b in boxes)
            {
                e.Graphics.FillRectangle(boxBrush, b.x, b.y, b.size, b.size);
                e.Graphics.FillEllipse(boxBrush, hero.x, hero.y, hero.size, hero.size);
            }
        }
    }
}
