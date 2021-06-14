using System;
namespace MediaLibrary {
    class Book : MediaType 
    {

        public string Author {get; private set;}

        public string DisplayText { 
            get
            {
                return $"Book: {this.Title} - {this.Author} {OnLoanDisplayText}";
            } 
        }
        public Book(string title, string author) : base(title){
            Author = author;
        } 


        public string GetTitle(){
            return this.Title;
        }
        public string GetAuthor(){
            return this.Author;
        }
    }
}