public class Exercise4
{
    public static void Run()
    {
        Invoice invoice = new Invoice(1000, "Yurii", "Some provider");
        System.Console.WriteLine($"Summ VAT: {invoice.PriceVAT}");
        System.Console.WriteLine($"Summ no VAT: {invoice.PriceWithoutVAT}");
    }
}

public class Invoice
{
    int account;
    string customer;
    string provider;

    private string article = "article";
    private int quantity = 4;

    const double VAT = 0.2;

    public Invoice(int account, string customer, string provider)
    {
        this.account = account;
        this.customer = customer;
        this.provider = provider;
    }

    public double PriceVAT => PriceWithoutVAT * (1 - VAT);
    public double PriceWithoutVAT => account * quantity;
}
