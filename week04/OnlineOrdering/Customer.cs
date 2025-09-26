using System;
using System.Reflection.Metadata.Ecma335;

class Customer
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
        return _address.PrintAddress();
    }

    public bool InUsa()
    {
        return _address.IsUsa();
    }
}