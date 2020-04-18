using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class TreehouseDefenseException : Exception
    {
        public TreehouseDefenseException()
        {

        }

        public TreehouseDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsExeption : TreehouseDefenseException
    {
        public OutOfBoundsExeption()
        {

        }
       public OutOfBoundsExeption(string message) : base(message)
        {

        }
    }
}
