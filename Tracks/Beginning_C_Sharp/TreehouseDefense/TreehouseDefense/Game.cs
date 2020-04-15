using System;

namespace TreehouseDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Tower tower = new Tower();
            Map map = new Map(8, 5);

            int area = map.Width * map.Height;
        }
    }
}
