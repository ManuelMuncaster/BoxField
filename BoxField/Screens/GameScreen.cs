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
using System.Media;

namespace BoxField
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;
        Boolean leftArrowUp, downArrowUp, rightArrowUp, upArrowUp;
        //used to draw boxes on screen
        public static SolidBrush boxBrush = new SolidBrush(Color.White);

        //List to hold a column of boxes
        List<Box> rightBoxes = new List<Box>();
        List<Box> leftBoxes = new List<Box>();
        List<Wall> walls = new List<Wall>();
        Wall topWall, bottomWall, victoryWall;

        //Box Values
        public int boxSize, boxSpeed1, boxSpeed2, boxSpeed3, newBoxCounter, colorCounter, color, red, green, blue;
        public string score;
        //hero Character
        Box hero;
        public int heroSpeed, heroColor;
        
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
            boxSpeed1 = 5;
            boxSpeed2 = 8;
            boxSpeed3 = 12;
            newBoxCounter = 0;
            colorCounter = 0;

            Box b1 = new Box(-40, 100, boxSize, boxSpeed1);
            Box b2 = new Box(-40, 50, boxSize, boxSpeed2);
            Box b3 = new Box(-40, 300, boxSize, boxSpeed3);
            Box b4 = new Box(1000, 200, boxSize, boxSpeed3);

            topWall = new Wall(-40, 0, 950, 5);
            bottomWall = new Wall(-40, 495, 950, 5);
            victoryWall = new Wall(-40, 20, 950, 5);

            leftBoxes.Add(b1);
            rightBoxes.Add(b4);

            //set hero values at start of game
            heroSpeed = 2;
            hero = new Box(this.Width / 2 - boxSize / 2, 400, boxSize, heroSpeed);

        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                //case Keys.Left:
                //    leftArrowDown = false;
                //    break;
                //case Keys.Down:
                //    downArrowDown = false;
                //    break;
                //case Keys.Right:
                //    rightArrowDown = false;
                //    break;
                //case Keys.Up:
                //    upArrowDown = false;
                //    break;
                //case Keys.B:
                //    bDown = false;
                //    break;
                //case Keys.N:
                //    nDown = false;
                //    break;
                //case Keys.M:
                //    mDown = false;
                //    break;
                //case Keys.Space:
                //    spaceDown = false;
                //    break;
                //default:
                //    break;

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
                //case Keys.Left:
                //    leftArrowDown = true;
                //    break;
                //case Keys.Down:
                //    downArrowDown = true;
                //    break;
                //case Keys.Right:
                //    rightArrowDown = true;
                //    break;
                //case Keys.Up:
                //    upArrowDown = true;
                //    break;
                //case Keys.B:
                //    bDown = true;
                //    break;
                //case Keys.N:
                //    nDown = true;
                //    break;
                //case Keys.M:
                //    mDown = true;
                //    break;
                //case Keys.Space:
                //    spaceDown = true;
                //    break;
                //default:
                //    break;

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

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //update location of all boxes (drop down screen)
            foreach (Box b in leftBoxes)
            {
                b.leftMove(); 
            }

            foreach (Box b in rightBoxes)
            {
                b.rightMove();
            }

            //add new box if it is time

            newBoxCounter++;

            if (newBoxCounter == 60)
            {
                //creating all of the boxes on the screen and adding them to lists.
                Box b1 = new Box(-40, 100, boxSize, boxSpeed3);
                Box b2 = new Box(-40, 130, boxSize, boxSpeed2);
                Box b3 = new Box(-40, 300, boxSize, boxSpeed1);
                Box b4 = new Box(1000, 200, boxSize, boxSpeed3);

                leftBoxes.Add(b1);
                leftBoxes.Add(b2);
                leftBoxes.Add(b3);
                rightBoxes.Add(b4);
                newBoxCounter = 0;
            }
            //Removing boxes after they leave the screen
            foreach (Box b in leftBoxes)
            {
                if (leftBoxes[0].x > this.Width - 20)
                {
                    leftBoxes.RemoveAt(0);
                    break;
                }
            }

            foreach (Box b in rightBoxes)
            {
                if (rightBoxes[0].x < -20)
                {
                    rightBoxes.RemoveAt(0);
                    break;
                }
            }

            //hero collison with the sides of the screen
            if (hero.x < -40)
            {
                hero.x = 900;
            }
            if (hero.x > 900)
            {
                hero.x = -40;
            }

            //move our hero
            if(leftArrowDown == true)
            {
                hero.Move("left");
                leftArrowDown = false;
            }
            if (leftArrowUp == true)
            {
                leftArrowDown = true;
            }

            if (rightArrowDown == true)
            {
                hero.Move("right");
                rightArrowDown = false;
            }
            if (rightArrowDown == true)
            {
                rightArrowDown = true;
            }

            if (upArrowDown == true)
            {
                hero.Move("up");
                upArrowDown = false;
            }
            if (upArrowUp == true)
            {
                upArrowUp = true;
            }

            if (downArrowDown == true)
            {
                hero.Move("down");
                downArrowDown = false;
            }
            if (downArrowUp == true)
            {
                downArrowUp = true;
            }

            //Check for collision between hero and boxes
            foreach (Box b in leftBoxes)
            {
                if (hero.Collision(b))
                {
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.squash);
                    player1.Play();
                    GameoverScreen gos = new GameoverScreen();
                    this.Controls.Add(gos);
                }
            }

            foreach (Box b in rightBoxes)
            {
                if (hero.Collision(b))
                {
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.squash);
                    player1.Play();
                    GameoverScreen gos = new GameoverScreen();
                    this.Controls.Add(gos);
                }
            }

            //check top wall
            if (hero.wallCollision(topWall))
            {
                hero.Move("down");
            }
            //check bottom wall
            if (hero.wallCollision(bottomWall))
            {
                hero.Move("up");
            }
            //check victory wall
            if (hero.wallCollision(victoryWall))
            {
                SoundPlayer player2 = new SoundPlayer(Properties.Resources.victory);
                player2.Play();
                Thread.Sleep(1500);
                victoryScreen vs = new victoryScreen();
                this.Controls.Add(vs);
            }

            Refresh();
        }

        private void colorLoop_Tick(object sender, EventArgs e)
        {
            colorCounter++;

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

                colorCounter = 0;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw boxes to screen

            foreach (Box b in leftBoxes)
            {
                e.Graphics.FillRectangle(boxBrush, b.x, b.y, b.size, b.size);
                e.Graphics.FillEllipse(boxBrush, hero.x, hero.y, hero.size, hero.size);
            }

            foreach (Box b in rightBoxes)
            {
                e.Graphics.FillRectangle(boxBrush, b.x, b.y, b.size, b.size);
            }
        }
    }
}
