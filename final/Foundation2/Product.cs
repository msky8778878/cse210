using System;

public class Product
{
    private string _name;
    private int _productID;
    private int _price;
    private int _quantity;

    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetTotalCost()
    {
        return _price * _quantity;
    }
}