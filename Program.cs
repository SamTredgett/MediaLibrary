using System;
namespace MediaLibrary 
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! I'm a cruddy Media Library!\n");
            // Song song =  new Song("Yesterday", "The Beatles");
            var song  = new Song();
            song.Title = "Yesterday";
            song.ArtistName = "The Beatles";
            Console.WriteLine($"The next song being played is:\t\t{song.GetTitle()} - {song.GetArtistName()}");

            // ###################################################################################################
            var film = new Film("The Dark Knight", "Christopher Nolan", 2.00);
            Console.WriteLine($"\nAnd tonight we will be watching:\t{film.GetTitle()} directed by {film.GetDirector()} which will last {film.GetRunTime()} hours");
        }
    }
}
