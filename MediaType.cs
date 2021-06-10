using System;

namespace MediaLibrary
{
    class MediaType {
        protected string Title;
        public bool LoanStatus;
        public string Loanee;

        public MediaType(string title){
            Title = title;
            LoanStatus = false;
        }
        public void Loan(string loanee)
    {
        if (!this.LoanStatus) {
            this.Loanee = loanee;
            this.LoanStatus = true;
            Console.WriteLine($"Item successfully loaned to: {Loanee}");
        }
        else{
            Console.WriteLine($"Unable to loan this to {loanee}, {this.LoanedBy()}");
        }
    }

    public void Return(){
        if (!this.LoanStatus){
            Console.WriteLine("This isn't on loan!");
        }
        else {
            this.LoanStatus = false;
            this.Loanee = null;
            Console.WriteLine("Thanks you for returning me!");
        }
    }

    public string LoanedBy(){
        return $"this is currently on loan to {Loanee}";
    }

    }






}