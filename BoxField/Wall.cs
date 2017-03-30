using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BoxField
{
    class Wall
    {
        public int x, y, width, height, size;

        public Wall(int _x, int _y, int _width, int _height, int _size)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            size = _size;
        }

        public Boolean wallCollision (Wall w)
        {
            Rectangle heroRec = new Rectangle(x, y, size, size);
            Rectangle topWall = new Rectangle(w.x, w.y, w.width, w.height);
            Rectangle bottomWall = new Rectangle(w.x, w.y, w.width, w.height);

            return heroRec.IntersectsWith(topWall);
            return heroRec.IntersectsWith(bottomWall);
        }
    }
}
