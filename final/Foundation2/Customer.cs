using System;

public class Customer
{
    private string _AScustomerName {get; set;}
    private Address _ASaddress {get; set;}

    public Customer (string AScustomerName, Address ASaddress)
    {
        _AScustomerName = AScustomerName;
        _ASaddress = ASaddress;
    }


    public double ASGetShippingCost()
    {
        double ASshippingCost;
        if (_ASaddress.ASGetCountry() == "USA")
        {
            ASshippingCost = 5;
        }
        else 
        {
            ASshippingCost = 35;
        }
        return ASshippingCost;
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"{_AScustomerName}\r\n{_ASaddress.ASGetAddress()}");
    }
}