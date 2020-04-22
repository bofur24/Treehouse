using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
           /* int index = 0;

            while (index < invaders.Length)
            {
                Invader invader = invaders[index];
                // Do stuff with invader

                index++;
            }
           */

          /*  for (int i = 0; i < invaders.Length; i++)
            {
                Invader invader = invaders[i];
                // Do stuff whith invader
            }
            */
            foreach(Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, 1))
                {
                    invader.DecreaseHealth(1);
                    break;
                }
            }
        }
    }
}
