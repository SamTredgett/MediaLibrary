using System;
namespace MediaLibrary {
    class Book : MediaType 
    {

        public string Author {get; private set;}

        public string DisplayText  => 
                $"Book: {this.Title} - {this.Author} {OnLoanDisplayText}";

        public Book(string title, string author) : base(title){
            Author = author;
        } 
    }
}