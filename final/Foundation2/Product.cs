using System;

public class Product
{
    private string _ASname {get; set;}
    private string _ASid {get; set;}
    private  double _ASprice {get; set;}
    private int _ASquantity {get; set;}

    public Product (string ASname, string ASid, double ASprice, int ASquantity)
    {
        _ASname = ASname;
        _ASid = ASid;
        _ASprice = ASprice;
        _ASquantity = ASquantity;
    }

    public double ASCalculatePrice()
    {
        return Math.Round((_ASprice * _ASquantity),2);
    }

    public void ASDisplayProductDetails()
    {
        Console.WriteLine($"{_ASname} ({_ASid}) => Total: ${ASCalculatePrice()}");
    }
}