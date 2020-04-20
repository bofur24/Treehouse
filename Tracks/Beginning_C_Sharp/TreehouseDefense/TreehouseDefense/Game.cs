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
                MapLocation[] path = {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)

                };
            }
            catch(OutOfBoundsExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");   
            }
            catch(Exception)
            {
                Console.WriteLine("Unhandled Exception");
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
