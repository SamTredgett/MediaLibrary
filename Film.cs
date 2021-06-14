using System;
namespace MediaLibrary{
class Film : MediaType {

        public string Director{get; private set;}
        public double RunTime {get; private set;}

        public string DisplayText { 
            get
            {
                return $"{this.Title} - {this.Director} with a runtime of {this.GetRunTime()} {OnLoanDisplayText}";
            } 
        }
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
    }
}