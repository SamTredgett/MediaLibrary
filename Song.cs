using System;
namespace MediaLibrary {
    class Song  : MediaType 
    {

        public string ArtistName {get; private set;}

        public string DisplayText => 
                $"Song: {this.ArtistName} - {this.Title} {OnLoanDisplayText}";

        public Song(string title, string artistName) : base(title){
            ArtistName = artistName;
        } 
    }
}
