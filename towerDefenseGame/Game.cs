using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefenseGame
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                MapLocation maplocation = new MapLocation(9, 9, map);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            //Point point = new Point(4, 2);
            //Console.WriteLine(point.DistanceTo(5, 5));

            //MapLocation x = new MapLocation(4, 2);
            //Console.WriteLine(x.DistanceTo(5, 5));

            //Console.WriteLine(x is MapLocation);
            //Console.WriteLine(x is Point);

            //Point point = new Point(0, 0);
            //Console.WriteLine(point is MapLocation);

            //-- Create point an call OnMap method and se if is on point.
            //Point point = new Point(4, 2);
            //bool isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);

            //point = new Point(8, 5);
            //isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);
        }
    }
}
