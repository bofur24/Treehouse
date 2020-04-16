using System;
using System.Collections.Generic;
using System.Text;

namespace Treehouse.MediaLibrary
{
    class Movie
    {

        public readonly string Title; // field added to the class
        public readonly string Director; // field added to the class
        public readonly int ReleaseDate; // field added to the class

        public Movie(string title, string director, int releaseDate)
        {
            Title = title;
            Director = director;
            ReleaseDate = releaseDate;
        }

    }
}
