using System;
namespace MediaLibrary 
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Song song =  new Song("Yesterday", "The Beatles");
            var song  = new Song();
            song.Title = "Yesterday";
            song.ArtistName = "The Beatles";
            Console.WriteLine($"The next song being played is:\t{song.GetTitle()} - {song.GetArtistName()}");
        }
    }
}
