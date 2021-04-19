using System;

public class ProductGetRes
{

    public string name { get; set; }
    public double price { get; set; }
    public ProductGetRes(string Name, double Price)
    {
        name = Name;
        price = Price;
    }
	
}
