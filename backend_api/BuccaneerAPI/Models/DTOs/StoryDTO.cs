public class StoryDTO
{
    public int id{get;set;}
    public int PirateID{get;set;}
    public string Title{get;set;}
    public string Content{get;set;}
    public DateTime Date{get;set;}

    public PirateDTO PirateDTO{get;set;}
}