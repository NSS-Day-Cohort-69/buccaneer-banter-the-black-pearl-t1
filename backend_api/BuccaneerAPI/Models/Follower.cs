namespace buccaneerbantertheblackpearlt1.Models;

public class Follower
{   
    public int Id{get;set;}
    public int PirateId{get;set;}
    public int FollowerId{get;set;}

    public Pirate Pirate{get;set;}
    public Pirate FollowerObj{get;set;}

}