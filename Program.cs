using System;
namespace MediaLibrary 
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! I'm a cruddy Media Library!\n");
            var song =  new Song("Yesterday", "The Beatles"); 
            Console.WriteLine($"The next song being played is:\t\t{song.GetTitle()} - {song.GetArtistName()}");

            // ###################################################################################################
            var film = new Film("The Dark Knight", "Christopher Nolan", 2.00);
            Console.WriteLine($"\nAnd tonight we will be watching:\t{film.GetTitle()} directed by {film.GetDirector()} which will last {film.GetRunTime()} hours");
            var book = new Book("Beyond Good & Evil", "Friedrich Nietzsche");
            Console.WriteLine($"\nLater tonight we'll be hearing a reading from {book.GetTitle()} by {book.GetAuthor()}");
        }
    }
}
