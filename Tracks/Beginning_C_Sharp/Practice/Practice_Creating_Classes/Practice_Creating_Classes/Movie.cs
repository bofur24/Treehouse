using System;
using System.Collections.Generic;
using System.Text;

namespace Treehouse.MediaLibrary
{
    class Movie
    {

        public readonly string Title;
        public readonly string Director;
        public readonly int ReleaseDate;

        public Movie(string title, string director, int releaseDate)
        {
            Title = title;
            Director = director;
            ReleaseDate = releaseDate;
        }

    }
}
