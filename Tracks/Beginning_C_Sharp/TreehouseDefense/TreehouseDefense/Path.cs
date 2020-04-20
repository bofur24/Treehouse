﻿using System;
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

        public GetLocationAt(int pathStep)
        {
            if (pathStep < _path.Length)
            {
                return _path[pathStep];
            }else
            {
                return null;
            }
            
            
        }
    }
}
