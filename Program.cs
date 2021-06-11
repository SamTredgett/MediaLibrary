using System;
namespace MediaLibrary 
{
    class Program
    {

        static void Main(string[] args)
        {
            try {
                // Generate a MediaLibrary object 
                var items = new MediaLibrary(new MediaType[]{
                    new Song("Yesterday", "The Beatles"), 
                    new Book("Beyond Good & Evil", "Friedrich Nietzsche"), 
                    new Film("The Dark Knight", "Christopher Nolan", 2.00)
                    });
                
                // Testing how to loan out items now
                items.GetItemAt(0).Loan("Sam");
                Display(items.GetItemAt(0));
                // All working nominally with once loaned.

                //testing the return after using the Return() method
                items.GetItemAt(0).Return();
                Display(items.GetItemAt(0));
                // All working nominally


                // Forcing an error on the GetItemAt(index) function to see if the error handling works
                items.GetItemAt(5);


                // book.Loan("Sam");
                // book.Loan("Sophie");
                // book.Return();

                // film.Loan("Sam");
                // film.Loan("Sophie");
                // film.Return();

                // song.Loan("Sam");
                // song.Loan("Sophie");
                // song.Return();


                // book.Loan("Sam");
                // film.Loan("Sam");
                // song.Loan("Sam");
                // // Running some tests to fix the boolean logic in the GetDisplayText method
                // Console.WriteLine($"\nAnd tonight we will be watching:\t{film.GetDisplayText()}");
                // Console.WriteLine($"\nLater tonight we'll be hearing a reading from {book.GetDisplayText()}");
                // Console.WriteLine($"The next song being played is:\t\t{song.GetTitle()} - {song.GetArtistName()}");

                // Test code for the empty/null string exception made in MediaType constructor
                // Console.WriteLine("test code");
                // var film2  = new Film("", "Hans Zimmer", 2.00);
                // Console.WriteLine("test code");

                DetectMediaType(items.GetItemAt(0));
                DetectMediaType(items.GetItemAt(1));
                DetectMediaType(items.GetItemAt(2));

                
            }
            catch(Exception ex){
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    public static void Display(MediaType item){
            if (item == null) {
                return;
            }
            else{
                    if(item is Book ){
                        Console.WriteLine(((Book)item).GetDisplayText());
                    }
                    else if(item is Film){
                        Console.WriteLine(((Film)item).GetDisplayText());                    
                    }
                    else if(item is Song){
                        Console.WriteLine(((Song)item).GetDisplayText());
                    }
                    else{
                        throw new Exception("Unexpected Media subtype encountered.");
                    } 
            }
        }
        public static void DetectMediaType(MediaType item){
            if (item ==null)
                {
                    return;
                }           
            if(item is Book ){
                Console.WriteLine($"{item.Title} is a Book!");
            }
            else if(item is Film){
                Console.WriteLine($"{item.Title} is a Film!");
            }
            else if(item is Song){
                Console.WriteLine($"{item.Title} is a Song!");
            }
            else{
                throw new Exception("Unexpected Media subtype encountered.");
            }

        }
    }
}
