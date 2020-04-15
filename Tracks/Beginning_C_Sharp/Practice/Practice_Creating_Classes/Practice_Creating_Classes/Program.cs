using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new VideoGames("Final Fantasy VI", 1995, "SquareEnix");
            var movie = new Movie("Frozen", "Jennifer Lee", 2013);
        
            Console.WriteLine($"VideoGames: {videoGames.Title} by {videoGames.Developer} published {videoGames.Published}");
            Console.WriteLine($"movie: {movie.Title} by {movie.Director} Released {movie.ReleaseDate}");

        }
    }
}
