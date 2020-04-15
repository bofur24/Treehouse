using System;

namespace TreehouseDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Tower tower = new Tower();
            Map map = new Map();


            map.Width = 8;
            map.Height = 5;

            int area = map.Width * map.Height;
        }
    }
}
