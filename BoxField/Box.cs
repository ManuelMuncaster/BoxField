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
        public int x, y, size, speed, color;

        /// <summary>
        /// Bob the Builder method for a ball object
        /// </summary>
        /// <param name="_x">sets the initial x coordinate</param>
        /// <param name="_y">sets the initial y coordinate</param>
        public Box (int _x, int _y, int _size, int _speed, int _color)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            color = _color;
        }
        public void Move()
        {
            y = y + speed;
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

        public void Color()
        {
            Random randGen = new Random();

            color = randGen.Next(1, 3);

        }



    }
}