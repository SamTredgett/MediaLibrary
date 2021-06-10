using System;
namespace MediaLibrary {
    class Book : MediaType {

    public string Author;

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
            return $"Book: {this.GetTitle()} by {this.GetAuthor()} (Currently on loan to {this.Loanee})";
        }
        else{
            return $"Book: {this.GetTitle()} by {this.GetAuthor()}";
        }
    }
}
}