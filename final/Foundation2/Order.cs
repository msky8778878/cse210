using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int GetTotalCost()
    {
        int totalcost = 0;
        foreach (Product product in _products)
        {
            totalcost += product.GetTotalCost();
        }

        if (_customer.LivesInUSA()) return totalcost + 5;
        else return totalcost + 35;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += product.GetProductID() + " - " + product.GetName() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}