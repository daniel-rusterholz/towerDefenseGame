using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefenseGame
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y) //Constructor
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared); 
            // Truncating decimal value with (int), because we dont care about the decimal

            //-- Puts together all of the above into a single line of code below here.
            //return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
        }

        // Overloaded the DistanceTo method - means to have methods that take different parameters.
        public int DistanceTo(Point point)  
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
