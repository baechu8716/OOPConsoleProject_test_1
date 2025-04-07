using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Vector2
    {
        public int x;
        public int y;

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator == (Vector2 right, Vector2 left)
        {
            return right.x == left.x && right.y == left.y;
        }

        public static bool operator != (Vector2 left, Vector2 right)
        {
            return right.x != left.x || right.y != left.y;
        }
    }
}
