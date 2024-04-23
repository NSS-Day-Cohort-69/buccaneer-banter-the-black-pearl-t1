namespace buccaneerbantertheblackpearlt1.Models;

public class FollowerDTO
{   
    public int Id{get;set;}
    public int PirateID{get;set;}
    public int FollowerId{get;set;}

    public PirateDTO PirateDTO{get;set;}
    public PirateDTO FollowerObjDTO{get;set;}

}