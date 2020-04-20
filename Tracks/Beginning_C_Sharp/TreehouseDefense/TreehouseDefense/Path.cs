using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;
        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            // Ternary if statement
            return (pathStep < _path.Length) ? _path[pathStep] : null;



            /*if (pathStep < _path.Length)
            {
                return _path[pathStep];
            }else
            {
                return null;
            }*/
            
            
        }
    }
}
