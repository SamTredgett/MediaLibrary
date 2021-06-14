using System;
namespace MediaLibrary {
    class Song  : MediaType 
    {

        public string ArtistName {get; private set;}

        public string DisplayText { 
            get
            {
                return $"Song: {this.ArtistName} - {this.Title} {OnLoanDisplayText}";
            } 
        }

        public Song(string title, string artistName) : base(title){
            ArtistName = artistName;
        } 

        public string GetTitle(){
            return this.Title;
        }
        public string GetArtistName(){
            return this.ArtistName;
        }
    }
}
