using System; 

public class Receptions : Event
{   
    private string _ASemail {get; set;}   

    public Receptions(string AStitle, string ASdescription, string ASdate, string AStime, string ASaddress, string AStype, string ASemail) : base (AStitle, ASdescription, ASdate, AStime, ASaddress, AStype)
    {
        _ASemail = ASemail;
    }

    public void ASDisplayReceptionsFullDetails()
    {   
        
        ASDisplayFullDetails();
        Console.WriteLine($"RSVP E-mail: {_ASemail}");
    }
}