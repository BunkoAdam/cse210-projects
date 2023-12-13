using System; 

public class Event
{
    private string _AStitle {get; set;}
    private string _ASdescription {get; set;}
    private string _ASdate {get; set;}
    private string _AStime {get; set;}
    private string _ASaddress {get; set;}
    private string _ASeventType {get; set;}

    public Event(string AStitle, string ASdescription, string ASdate, string AStime, string ASaddress, string AStype)
    {
        _AStitle = AStitle;
        _ASdescription = ASdescription;
        _ASdate = ASdate; 
        _AStime = AStime; 
        _ASaddress = ASaddress; 
        _ASeventType = AStype;
    }

    public void ASDisplayShortDescription()
    {
        Console.WriteLine($"Event Type: {_ASeventType}");
        Console.WriteLine($"Name: {_AStitle}");
        Console.WriteLine($"Date: {_ASdate}");
    }

    public void ASDisplayStandardDetails() 
    {
        Console.WriteLine($"Name: {_AStitle}");
        Console.WriteLine($"Description: {_ASdescription}");
        Console.WriteLine($"Date: {_ASdate}");
        Console.WriteLine($"Time: {_AStime}");
        Console.WriteLine($"Address: {_ASaddress}");
    }

    public void ASDisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {_ASeventType}");
        Console.WriteLine($"Name: {_AStitle}");
        Console.WriteLine($"Description: {_ASdescription}");
        Console.WriteLine($"Date: {_ASdate}");
        Console.WriteLine($"Time: {_AStime}");
        Console.WriteLine($"Address: {_ASaddress}");
    }
    
}