using System;
namespace MediaLibrary 
{
    class Program
    {

        static void Main(string[] args)
        {
            try {
                
                MediaType[] MyMedia = {
                    new Song("Yesterday", "The Beatles"), 
                    new Book("Beyond Good & Evil", "Friedrich Nietzsche"), 
                    new Film("The Dark Knight", "Christopher Nolan", 2.00)
                    };

                Console.WriteLine("Hello World! I'm a cruddy Media Library!\n");
                Console.WriteLine($"The next song being played is:\t\t{Display(MyMedia[0])}");
                // Console.WriteLine(Display(MyMedia[0]));

                // ###################################################################################################
                Console.WriteLine($"\nAnd tonight we will be watching:\t{Display(MyMedia[2])}");
                Console.WriteLine($"\nLater tonight we'll be hearing a reading from {Display(MyMedia[1])}");

                // Creating array of MediaType Objects
                
                Console.WriteLine(MyMedia[1].Title);


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

                Console.WriteLine(DetectMediaType(MyMedia[0]));
                Console.WriteLine(DetectMediaType(MyMedia[1]));
                Console.WriteLine(DetectMediaType(MyMedia[2]));

                
            }
            catch(Exception ex){
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    public static string Display(MediaType item){
            
            if(item is Book ){
                return ((Book)item).GetDisplayText();
            }
            else if(item is Film){
                return ((Film)item).GetDisplayText();
            }
            else if(item is Song){
                return ((Song)item).GetDisplayText();
            }
            else{
                throw new Exception("Unexpected Media subtype encountered.");
            }

        }
        public static string DetectMediaType(MediaType item){
            
            if(item is Book ){
                return $"{item.Title} is a Book!";
            }
            else if(item is Film){
                return $"{item.Title} is a Film!";
            }
            else if(item is Song){
                return $"{item.Title} is a Song!";
            }
            else{
                throw new Exception("Unexpected Media subtype encountered.");
            }

        }
    }
}
