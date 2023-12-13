using System; 

public class Outdoor : Event
{   
    private string _ASweather {get; set;}   

    public Outdoor(string AStitle, string ASdescription, string ASdate, string AStime, string ASaddress, string AStype, string ASweather) : base (AStitle, ASdescription, ASdate, AStime, ASaddress, AStype)
    {
        _ASweather = ASweather;
    }

       public void ASDisplayOutdoorFullDetails()
    {
        ASDisplayFullDetails();
        Console.WriteLine($"Weather: {_ASweather}");
    }
}