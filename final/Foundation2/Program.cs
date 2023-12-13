using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("---------------------------------------------");
        //order 1 
        Address ASaddress1 = new Address ("66 Order Drive", "Mustafar", "ID", "USA");
        Customer AScustomer1 = new Customer("Anakin Skywalker", ASaddress1);

        double ASorder1ShippingCost = AScustomer1.ASGetShippingCost();

        Product ASorder1Product1 = new Product("Light Saber", "4131", 100.00, 1);
        Product ASorder1Product2 = new Product("Robe", "4225", 20.00, 4);

        Order ASorder1 = new Order(AScustomer1);
        ASorder1.ASAddProduct(ASorder1Product1);
        ASorder1.ASAddProduct(ASorder1Product2);
        double ASorder1Subtotal = ASorder1.ASCalculateSubtotal();
        double ASorder1Total = ASorder1.ASCalculateTotal();

        //display order 1
        ASorder1.ASDisplayShippingLabel(); 
        Console.WriteLine();
        ASorder1.ASDisplayPackingLabel();
        Console.WriteLine();
        ASorder1.ASDisplayCosts(ASorder1Subtotal ,ASorder1ShippingCost, ASorder1Total);


        Console.WriteLine("---------------------------------------------");


        //order 2
        Address ASaddress2 = new Address ("Number 4 Privet Drive", "Little Whinging", "WiltShire", "England");
        Customer AScustomer2 = new Customer("Harry Potter", ASaddress2);

        double ASorder2ShippingCost = AScustomer2.ASGetShippingCost();

        Product ASorder2Product1 = new Product("Wand", "4260", 10.00, 1);
        Product ASorder2Product2 = new Product("Book", "4959", 5.00, 5);
        Product ASorder2Product3 = new Product("Robe", "4029", 25.00, 3);

        Order ASorder2 = new Order(AScustomer2);
        ASorder2.ASAddProduct(ASorder2Product1);
        ASorder2.ASAddProduct(ASorder2Product2);
        ASorder2.ASAddProduct(ASorder2Product3);
        double ASorder2Subtotal = ASorder2.ASCalculateSubtotal();
        double ASorder2Total = ASorder2.ASCalculateTotal();


        //display order 2
        ASorder2.ASDisplayShippingLabel(); 
        Console.WriteLine();
        ASorder2.ASDisplayPackingLabel();
        Console.WriteLine();
        ASorder2.ASDisplayCosts(ASorder2Subtotal, ASorder2ShippingCost, ASorder2Total);
        Console.WriteLine("---------------------------------------------");

    }   
}