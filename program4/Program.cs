//using System;

//class Discount
//{
//    public double GetDiscount(string customerType, double amount)
//    {
//        if (customerType == "Regular")
//            return amount * 0.10;

//        else if (customerType == "Premium")
//            return amount * 0.20;

//        else
//            throw new Exception("Customer type not supported");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Discount d = new Discount();
//        Console.WriteLine(d.GetDiscount("Regular", 1000));
//        Console.WriteLine(d.GetDiscount("Premium", 1000));
//    }
//}


using System;

// Interface
interface IDiscount
{
    double Calculate(double amount);
}

//Implementations
class RegularCustomer : IDiscount
{
    public double Calculate(double amount)
    {
        return amount * 0.10;
    }
}

class PremiumCustomer : IDiscount
{
    public double Calculate(double amount)
    {
        return amount * 0.20;
    }
}

//Calculator (closed for modification)
class DiscountCalculator
{
    private IDiscount discount;

    public DiscountCalculator(IDiscount discount)
    {
        this.discount = discount;
    }

    public double GetDiscount(double amount)
    {
        return discount.Calculate(amount);
    }
}

// Usage
class Program
{
    static void Main()
    {
        DiscountCalculator regular =
            new DiscountCalculator(new RegularCustomer());
        Console.WriteLine(regular.GetDiscount(1000));

        DiscountCalculator premium =
            new DiscountCalculator(new PremiumCustomer());
        Console.WriteLine(premium.GetDiscount(1000));
    }
}
