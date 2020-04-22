using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        public MapLocation Location => _path.GetLocationAt(_pathStep);
 
        public Invader(Path  path)
        {
            _path = path;
           
        }

        public void move() => _pathStep += 1; // syntactic sugar removes the braces from simple methods and properties and makes one-liners.
 





        /* Methods that do the same as the get and set being removed 


           public MapLocation GetLocation()
           {
               return _Location;
           }

           public void SetLocation(MapLocation value)
           {
               _Location = value;
           }
       */




    }


}
