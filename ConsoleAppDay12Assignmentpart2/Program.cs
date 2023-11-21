using System;

class Product
{
    protected int pid;
    protected string pname;
    protected double pprice;

    public virtual void ShowDetails()
    {
        Console.WriteLine($"Product ID: {pid}");
        Console.WriteLine($"Product Name: {pname}");
        Console.WriteLine($"Product Price: {pprice}");
    }

    public virtual void SetInformation(int id, string name, double price)
    {
        pid = id;
        pname = name;
        pprice = price;
    }
}

class HerbalProduct : Product
{
    private string herbsUsed;
    private DateTime mfDate;
    private DateTime expDate;

    public override void ShowDetails()
    {
        base.ShowDetails(); // Call base class method
        Console.WriteLine($"Herbs Used: {herbsUsed}");
        Console.WriteLine($"Manufacturing Date: {mfDate.ToShortDateString()}");
        Console.WriteLine($"Expiry Date: {expDate.ToShortDateString()}");
    }

    public override void SetInformation(int id, string name, double price)
    {
        base.SetInformation(id, name, price); // Call base class method
        Console.Write("Enter Herbs Used: ");
        herbsUsed = Console.ReadLine();
        Console.Write("Enter Manufacturing Date (dd-mm-yyyy): ");
        mfDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter Expiry Date (dd-mm-yyyy): ");
        expDate = DateTime.Parse(Console.ReadLine());
    }
}

class Program
{
    static void Main()
    {
        HerbalProduct herbalProduct = new HerbalProduct();
        Console.WriteLine("Enter Herbal Product Details:");
        herbalProduct.SetInformation(1, "Herbal Shampoo", 10.99);

        Console.WriteLine("\nHerbal Product Details:");
        herbalProduct.ShowDetails();
    }
}
