namespace MediaLibrary{
class Film {
    private string Title;
    private string Director;
    private double RunTime;

    public Film(string title, string director, double runTime){
        Title = title;
        Director = director;
        RunTime = runTime;
    }

    private string GetTitle(){
        return this.Title;
    }

    private string GetDirectory(){
        return this.Director;
    }

    private double getRunTime(){
        return this.RunTime;
    }

}
}