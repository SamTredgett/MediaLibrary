using System;
namespace MediaLibrary{
class Film {
    private string Title;
    private string Director;
    private double RunTime;


    public bool LoanStatus;

    public string Loanee;
    public Film(string title, string director, double runTime){
        Title = title;
        Director = director;
        RunTime = runTime;
        LoanStatus = false;
    }

    public string GetTitle(){
        return this.Title;
    }

    public string GetDirector(){
        return this.Director;
    }

    public double GetRunTime(){
        return this.RunTime;
    }
    public string GetDisplayText(){
        return $"Film: {this.GetTitle()} by {this.GetDirector()} and it runs for {this.GetRunTime()} hours";
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
            Console.WriteLine($"Unable to loan this film to {loanee}, {this.LoanedBy()}");
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
        return $"This film is currently on loan by {Loanee}";
    }
}
}