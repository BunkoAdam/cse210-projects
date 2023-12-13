using System;

public class Order
{
    private List<Product> _ASproducts = new List<Product>();
    private Customer _AScustomer {get; set;}

    public Order (Customer AScustomer)
    {
        _AScustomer = AScustomer;
    }

    public void ASAddProduct(Product ASproduct)
    {
        _ASproducts.Add(ASproduct);
    }

    public double ASCalculateSubtotal() 
    {
        double ASsubtotal = 0;
        foreach (Product ASproduct in _ASproducts)
        {
            double ASproductPrice = ASproduct.ASCalculatePrice();
            ASsubtotal += ASproductPrice;
        }
        ASsubtotal = Math.Round(ASsubtotal, 2);
        return ASsubtotal;
    }

    public double ASCalculateTotal()
    {
        double AStotal = Math.Round((ASCalculateSubtotal() + _AScustomer.ASGetShippingCost()),2);
        return AStotal;
    }

    public void ASDisplayCosts(double ASsubtotal, double ASshippingCost, double AStotalCost)
    {   
        Console.WriteLine($"Subtotal: ${ASsubtotal}");
        Console.WriteLine($"Shipping: ${ASshippingCost}");
        Console.WriteLine($"Total: ${AStotalCost}");
    }

    public void ASDisplayPackingLabel()
    {   
        Console.WriteLine("Packing Label");
        foreach (Product ASproduct in _ASproducts)
        {
            ASproduct.ASDisplayProductDetails();
        }
        
    }
    public void ASDisplayShippingLabel()
    {   
        Console.WriteLine("Shipping Label");
        Console.WriteLine("SHIP TO: ");
        _AScustomer.DisplayCustomer();
    }

    
}