namespace MediaLibrary {
    class Song {
    public string Title;
    public string ArtistName;

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
        return $"Song: {this.GetTitle()} by {this.GetArtistName()}.";
    }
}
}
