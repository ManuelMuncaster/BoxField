using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BoxField
{
    public class Box
    {
        public int x, y, size, speed, color, red, blue, green, direction;

        /// <summary>
        /// Bob the Builder method for a ball object
        /// </summary>
        /// <param name="_x">sets the initial x coordinate</param>
        /// <param name="_y">sets the initial y coordinate</param>
        public Box (int _x, int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
        }
        public void Move()
        {
            y = y + speed;
        }

        public void moveDirection()
        {
            Random randGen = new Random();
            direction = randGen.Next(1, 3);

            if (direction == 1)
            {
                x = x + 25;
            }
            if (direction == 2)
            {
                x = x - 25;
            }

            direction = 0;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x = x - speed;
            }

            if (direction == "right")
            {
                x = x + speed;
            }
        }

        public Boolean Collision (Box b)
        {
            Rectangle boxRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle heroRec = new Rectangle(x, y, size, size);

            return boxRec.IntersectsWith(heroRec);
        }
    }
}