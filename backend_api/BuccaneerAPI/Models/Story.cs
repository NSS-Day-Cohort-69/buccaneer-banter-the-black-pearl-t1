namespace buccaneerbantertheblackpearlt1.Models;

public class Story{
    public int Id{get;set;}
    public int PirateId{get;set;}
    public string Title{get;set;}
    public string Content{get;set;}
    public DateTime Date{get;set;}

    public Pirate Pirate{get;set;}
}