namespace MediaLibrary {
    class Book {
    public string Title;
    public string Author;

    public Book(string title, string author){
        Author = author;
        Title = title;
    } 

    public string GetTitle(){
        return this.Title;
    }
    public string GetAuthor(){
        return this.Author;
    }
}
}