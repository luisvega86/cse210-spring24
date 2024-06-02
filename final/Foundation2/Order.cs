using System;
using System.Text;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public string GetPackingLabel()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (var product in _products)
        {
            sb.AppendLine(product.DisplayNameAndId());
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {   
        return $"Shipping to:\n{_customer.DisplayCustomerInfo()}";
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        return total;
    }
}