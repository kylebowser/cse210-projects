using System;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void SetProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.totalCost();
        }

        if (_customer.InUsa())
        {
            return (totalCost + 5);
        }
        else
        {
            return (totalCost + 35);
        }
        
    }

    public string ShippingLabel()
    {
        return ($"{_customer.GetName()} \n{_customer.GetAddress()}");
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetName();
            packingLabel += " ";
            packingLabel += product.GetProductId().ToString();
            packingLabel += "\n";
        }   
        return ($"{packingLabel}");
    }
}