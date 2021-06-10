using System;
namespace MediaLibrary {
    class Book {
    public string Title;
    public string Author;
    public bool LoanStatus;

    public string Loanee;

    public Book(string title, string author){
        Author = author;
        Title = title;
        LoanStatus = false;
    } 

    public string GetTitle(){
        return this.Title;
    }
    public string GetAuthor(){
        return this.Author;
    }
    public string GetDisplayText(){
        return $"Book: {this.GetTitle()} by {this.GetAuthor()}";
    }

    public bool OnLoan(){
        return LoanStatus;
    }
    public void Loan(string loanee)
    {
        if (!this.OnLoan()) {
            this.Loanee = loanee;
            this.LoanStatus = true;
            Console.WriteLine($"{this.GetDisplayText()} has been loaned to {loanee}");
        }
        else{
            Console.WriteLine($"Unable to loan this book to {loanee}, {this.LoanedBy()}");
        }
    }

    public void Return(){
        if (!this.OnLoan()){
            Console.WriteLine($"{this.GetDisplayText()} is not on loan!");
        }
        else {
            this.LoanStatus = false;
            this.Loanee = null;
            Console.WriteLine("Thanks you for returning me!");
        }
    }

    public string LoanedBy(){
        return $"This book is currently on loan by {Loanee}";
    }

}
}