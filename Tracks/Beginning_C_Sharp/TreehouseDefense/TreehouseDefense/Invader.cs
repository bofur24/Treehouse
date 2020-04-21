using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class Invader
    {
        private MapLocation _Location;

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
        public MapLocation Location
        {
            get
            {
                return _Location;
            }
            set
            {
                _Location = value;
                Console.WriteLine("Location changed");
            }
              
        }


    }


}
