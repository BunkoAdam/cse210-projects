using System;

public class Address
{
    private string _ASstreetAddress {get; set;}
    private string _AScity {get; set;}
    private string _ASstate {get; set;}
    private string _AScountry {get; set;}

    public Address (string ASstreetAddress, string AScity, string ASstate, string AScountry)
    {
        _ASstreetAddress = ASstreetAddress;
        _AScity = AScity;
        _ASstate = ASstate;
        _AScountry = AScountry;
    }

    public void ASSetCountry(string AScountry)
    {
        _AScountry = AScountry;
    }
    public string ASGetCountry()
    {
        return _AScountry;
    }

    public string ASGetAddress() 
    {
        return $"{_ASstreetAddress}\r\n{_AScity}, {_ASstate}\r\n{_AScountry}";
    }
}