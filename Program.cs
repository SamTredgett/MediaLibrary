using System;
namespace MediaLibrary 
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! I'm a cruddy Media Library!\n");
            var song =  new Song("Yesterday", "The Beatles"); 
            //Console.WriteLine($"The next song being played is:\t\t{song.GetTitle()} - {song.GetArtistName()}");
            Console.WriteLine(song.GetDisplayText());

            // ###################################################################################################
            var film = new Film("The Dark Knight", "Christopher Nolan", 2.00);
            Console.WriteLine($"\nAnd tonight we will be watching:\t{film.GetDisplayText()}");
            var book = new Book("Beyond Good & Evil", "Friedrich Nietzsche");
            Console.WriteLine($"\nLater tonight we'll be hearing a reading from {book.GetDisplayText()}");

            book.Loan("Sam");
            book.Loan("Sophie");
            book.Return();

            film.Loan("Sam");
            film.Loan("Sophie");
            film.Return();

            song.Loan("Sam");
            song.Loan("Sophie");
            song.Return();

        }
    }
}
