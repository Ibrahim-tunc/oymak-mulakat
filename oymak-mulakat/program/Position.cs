using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibocan
{
    class Position
    {

        public int x { get; set; }
        public int y { get; set; }
        public Direction direction { get; set; }

        public Position(int x,int y,char direction)
        {
            this.x = x;
            this.y = y;
            this.direction = (Direction)Convert.ToChar(direction);

        }

        public Position(int x, int y, Direction direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

       

        public override string ToString()
        {
            return Convert.ToString(x) + " " + Convert.ToString(y) + " " + (char)direction;
        }

    }
}
