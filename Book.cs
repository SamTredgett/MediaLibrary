using System;
namespace MediaLibrary {
    class Book : MediaType 
    {

        public string Author {get; private set;}

        public Book(string title, string author) : base(title){
            Author = author;
        } 

        public string GetTitle(){
            return this.Title;
        }
        public string GetAuthor(){
            return this.Author;
        }
        public string GetDisplayText(){
            if(this.LoanStatus){
                return $"{this.GetTitle()} by {this.GetAuthor()} (Currently on loan to {this.Loanee})";
            }
            else{
                return $"{this.GetTitle()} by {this.GetAuthor()}";
            }
        }
    }
}