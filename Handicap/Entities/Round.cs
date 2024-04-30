namespace Handicap.Entities;

public class Round
{
    public int Id { get; set; }
    public int score { get; set; }
    
    public String course { get; set; }
    public int slope { get; set; }
    
    public float rating { get; set; }
    
    public DateOnly date { get; set; }
    
    public float differential => ((score - rating) * 113)  / slope;

}