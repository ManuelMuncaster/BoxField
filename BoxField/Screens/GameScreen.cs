using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxField
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //used to draw boxes on screen
        SolidBrush boxBrush = new SolidBrush(Color.FromArgb)

        //List to hold a column of boxes
        List<Box> boxes = new List<Box>();

        //Box Values
        int boxSize, boxSpeed, newBoxCounter, boxColor;

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

            

            Box b1 = new Box(200, -40, boxSize, boxSpeed, boxColor);
            boxes.Add(b1);

            Box b2 = new Box(500, -40, boxSize, boxSpeed, boxColor);
            boxes.Add(b2);

            //set hero values at start of game
            heroSpeed = 7;
            hero = new Box(this.Width / 2 - boxSize / 2, 400, boxSize, heroSpeed, heroColor);

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

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //update location of all boxes (drop down screen)
            foreach (Box b in boxes)
            {
                b.Move();
            }

            //remove box if it has gone of screen

            //add new box if it is time

            newBoxCounter++;

            if(newBoxCounter == 5)
            {
                Box b1 = new Box(200, -40, boxSize, boxSpeed, boxColor);
                boxes.Add(b1);

                Box b2 = new Box(500, -40, boxSize, boxSpeed, boxColor);
                boxes.Add(b2);

                Random randGen = new Random();
                boxColor = randGen.Next(1, 3); 

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
