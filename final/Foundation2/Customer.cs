using System;

public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetDisplayString();
    }

    public bool LivesInUSA()
    {
        return _address.LivesInUSA();
    }
}