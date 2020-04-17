using System;

namespace TreehouseDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            //Tower tower = new Tower();
            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }






           // MapLocation x = new MapLocation(4, 2);

            //Point p = x;

            //map.OnMap(new MapLocation(0, 0));

           //Console.WriteLine(x.DistanceTo(5, 5));

            //Console.WriteLine(x is MapLocation);
            //Console.WriteLine(x is Point);

            //Point point = new Point(0, 0);
            //Console.WriteLine(point is MapLocation);

            
        }
    }
}
