using System;
namespace MediaLibrary {
    class Song  : MediaType 
    {

        public string ArtistName;

        public Song(string title, string artistName) : base(title){
            ArtistName = artistName;
        } 

        public string GetTitle(){
            return this.Title;
        }
        public string GetArtistName(){
            return this.ArtistName;
        }

        public string GetDisplayText(){
            if(this.LoanStatus){
                return $"{this.GetTitle()} - {this.GetArtistName()} (currently on loan to {this.Loanee})";
            }
            else{
                return $"{this.GetTitle()} - {this.GetArtistName()}";
            }
        }
    }
}
