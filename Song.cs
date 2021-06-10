using System;
namespace MediaLibrary {
    class Song {
    public string Title;
    public string ArtistName;
    public bool LoanStatus;

    public string Loanee;
    public Song(string title, string artistName){
        ArtistName = artistName;
        Title = title;
    } 

    public string GetTitle(){
        return this.Title;
    }
    public string GetArtistName(){
        return this.ArtistName;
    }

    public string GetDisplayText(){
        if(this.OnLoan()){
            return $"Song: {this.GetTitle()} by {this.GetArtistName()} (currently on loan by {this.Loanee})";
        }
        else{
            return $"Song: {this.GetTitle()} by {this.GetArtistName()}";
        }
    }

    public bool OnLoan(){
        return LoanStatus;
    }
    public void Loan(string loanee)
    {
        if (!this.OnLoan()) {
            this.Loanee = loanee;
            this.LoanStatus = true;
            Console.WriteLine(this.GetDisplayText());
        }
        else{
            Console.WriteLine($"Unable to loan this record to {loanee}, {this.LoanedBy()}");
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
        return $"This record is currently on loan to {Loanee}";
    }
}
}
