using System; 

public class Address
{
    private string _ASstreetAddress {get; set;}
    private string _AScity {get; set;}
    private string _ASstate {get; set;}
    private string _ASpostalCode {get; set;}
    private string _AScountry {get; set;}

    public Address (string ASstreetAddress, string AScity, string ASstate, string ASpostalCode, string AScountry)
    {
        _ASstreetAddress = ASstreetAddress;
        _AScity = AScity;
        _ASstate = ASstate;
        _ASpostalCode = ASpostalCode;
        _AScountry = AScountry;
    }

    public string ASGetAddress()
    {
        return $"{_ASstreetAddress}, {_AScity}, {_ASstate} {_ASpostalCode} {_AScountry}";
    }
}