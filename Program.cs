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
                
                items.DisplayItems();


                var testItem = items.FindItem("yesterday");
                if(testItem != null){
                    MediaLibrary.DisplayItem(testItem);
                }
                else{
                    Console.WriteLine("Item not found!");
                }
                // testItem.Display();
                DetectMediaType(testItem);
                // Console.WriteLine(testItem.DisplayItem());
                // Forcing an error on the GetItemAt(index) function to see if the error handling works
                items.GetItemAt(5);


                items.GetItemAt(0).Loan("Sam");
                items.GetItemAt(0).Loan("Sophie");
                items.GetItemAt(0).Return();

                items.GetItemAt(1).Loan("Sam");
                items.GetItemAt(1).Loan("Sophie");
                items.GetItemAt(1).Return();

                items.GetItemAt(2).Loan("Sam");
                items.GetItemAt(2).Loan("Sophie");
                items.GetItemAt(2).Return();


                items.GetItemAt(0).Loan("Sam");
                items.GetItemAt(1).Loan("Sam");
                items.GetItemAt(2).Loan("Sam");


                Console.WriteLine(items.NumberOfItems);
                // Console.WriteLine($"\nAnd tonight we will be watching:\t{items.GetItemAt(0).DisplayText}");
                // Console.WriteLine($"\nLater tonight we'll be hearing a reading from {book.Display()}");
                // Console.WriteLine($"The next song being played is:\t\t{song.Display()}");


                DetectMediaType(items.GetItemAt(0));
                DetectMediaType(items.GetItemAt(1));
                DetectMediaType(items.GetItemAt(2));

                
            }
            catch(Exception ex){
                Console.WriteLine("Exception: {0}", ex.Message);
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
