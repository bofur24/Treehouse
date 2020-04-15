using System;
using System.Collections.Generic;
using System.Text;

namespace Treehouse.MediaLibrary
{
    class VideoGames
    {
        public readonly string Title;
        public readonly int Published;
        public readonly string Developer;

        public VideoGames(string title, int published, string developer)
        {
            Title = title;
            Published = published;
            Developer = developer;
        }
    }
}
