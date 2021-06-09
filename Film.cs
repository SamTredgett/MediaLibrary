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