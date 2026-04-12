using System;

public class OrderService
{
    public void CreateOrder(string customerName, string product, double price, int quantity)
    {
        double total = price * quantity;
        Console.WriteLine("✅ Order Created!");
        Console.WriteLine($"   Customer: {customerName}");
        Console.WriteLine($"   Product: {product}, Quantity: {quantity}");
        Console.WriteLine($"   Total: {total} TK");

        ProcessPayment(customerName, total);
        SaveToDatabase(customerName, product, total);
        SendEmail(customerName, product);
        GenerateInvoice(customerName, product, total);

        Console.WriteLine("\n🎉 Order process complete!");
    }

    private void ProcessPayment(string customerName, double amount)
    {
        Console.WriteLine($"\n💳 Processing payment of {amount} TK via bKash...");
        Console.WriteLine("   Connecting to bKash API...");
        Console.WriteLine($"   bKash: Payment of {amount} TK successful!");
    }

    private void SaveToDatabase(string customerName, string product, double total)
    {
        Console.WriteLine("\n💾 Saving order to database...");
        Console.WriteLine($"   SQL: INSERT INTO Orders VALUES('{customerName}', '{product}', {total})");
        Console.WriteLine("   Database: Order saved successfully!");
    }

    private void SendEmail(string customerName, string product)
    {
        Console.WriteLine("\n📧 Sending confirmation email...");
        Console.WriteLine($"   SMTP: Connecting to mail server...");
        Console.WriteLine($"   To: {customerName.ToLower()}@email.com");
        Console.WriteLine($"   Subject: Order Confirmed!");
        Console.WriteLine($"   Body: Dear {customerName}, your order for {product} has been placed.");
        Console.WriteLine("   Email sent successfully!");
    }

    private void GenerateInvoice(string customerName, string product, double total)
    {
        Console.WriteLine("\n📄 Generating invoice PDF...");
        Console.WriteLine($"   Creating: Invoice_{customerName}_{product}.pdf");
        Console.WriteLine("   Adding header, items, total...");
        Console.WriteLine("   PDF generated successfully!");
    }
}

class Program
{
    static void Main()
    {
        OrderService service = new OrderService();
        service.CreateOrder("Rahim", "iPhone 15", 150000, 1);
    }
}