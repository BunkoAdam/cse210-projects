using System; 

public class Lectures : Event
{
    private string _ASspeakerName {get; set;}    
    private int _AScapacity {get; set;}    

    public Lectures(string AStitle, string ASdescription, string ASdate, string AStime, string ASaddress, string AStype, string ASspeakerName, int AScapacity) : base (AStitle, ASdescription, ASdate, AStime, ASaddress, AStype)
    {
        _ASspeakerName = ASspeakerName;
        _AScapacity = AScapacity;
    }

    public void ASDisplayLectureFullDetails()
    {
        ASDisplayFullDetails();
        Console.WriteLine($"Speaker: {_ASspeakerName}");
        Console.WriteLine($"Capacity: {_AScapacity}");
    }
}