using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames1 = new VideoGames("Final Fantasy VI", 1995, "Square");       // instance of my media type class VideoGames, VideoGames object.
            var videoGames2 = new VideoGames("Final Fantasy VII", 1999, "SquareEnix");  // instance of my media type class VideoGames, VideoGames object.
            var videoGames3 = new VideoGames("Final Fantasy VIII", 2001, "SquareEnix");


            var movie = new Movie("Frozen", "Jennifer Lee", 2013);                      // instance of my media type class Movie, Movie object.

            Console.WriteLine(videoGames1.GetDisplayText());
            Console.WriteLine(videoGames2.GetDisplayText());
            Console.WriteLine(videoGames3.GetDisplayText());
            Console.WriteLine("");
        
             
            Console.WriteLine($"movie: {movie.Title} by {movie.Director} Released {movie.ReleaseDate}");   // writeing each media type object to the console.
            Console.WriteLine("");

            videoGames1.Loan("Derrick Hamer");
            videoGames2.Loan();

            Console.WriteLine(videoGames1.GetDisplayText());
            Console.WriteLine(videoGames2.GetDisplayText());


            videoGames1.Return();
            videoGames2.Return();

            Console.WriteLine(videoGames1.GetDisplayText());
            Console.WriteLine(videoGames2.GetDisplayText());



        }
    }
}
