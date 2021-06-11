using System;
namespace MediaLibrary{
class Film : MediaType {

        private string Director;
        private double RunTime;

        public Film(string title, string director, double runTime) : base(title){
            Director = director;
            RunTime = runTime;
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
            if(this.LoanStatus){
                return $"{this.GetTitle()} by {this.GetDirector()} and it runs for {this.GetRunTime()} hours (Currently on Loan to {this.Loanee})";
            }
            else{
                return $"{this.GetTitle()} by {this.GetDirector()} and it runs for {this.GetRunTime()} hours";
            }
        }
    }
}