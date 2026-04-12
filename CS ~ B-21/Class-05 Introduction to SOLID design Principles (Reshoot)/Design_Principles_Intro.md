# Design Principles (ডিজাইন প্রিন্সিপাল) কী?

সফটওয়্যার ইঞ্জিনিয়ারিং-এ **Design Principles** হলো কিছু সাধারণ নিয়ম, গাইডলাইন বা বেস্ট প্র্যাকটিস (Best Practices), যা ডেভেলপারদেরকে একটি ভালো, রিডেবল (Readable), এবং মেইনটেইনেবল (Maintainable) সফটওয়্যার আর্কিটেকচার ডিজাইন করতে সাহায্য করে। 

এগুলো কোনো নির্দিষ্ট প্রোগ্রামিং ভাষার (Programming Language) উপর নির্ভরশীল নয়। বরং এগুলো হলো এমন কিছু কনসেপ্ট, যা মেনে চললে কোডের গুণগত মান উন্নত হয় এবং দীর্ঘমেয়াদে সফটওয়্যার পরিচালনা করা সহজ হয়।

সহজ কথায়, একটি টেকসই ও মজবুত বাড়ি তৈরি করতে যেমন একটি সুন্দর নকশা ও ইঞ্জিনিয়ারিং নিয়মকানুন মেনে চলতে হয়, ঠিক তেমনি একটি ভালো ও বাগ-ফ্রি (Bug-free) সফটওয়্যার তৈরি করতে ডিজাইন প্রিন্সিপালগুলো অনুসরণ করতে হয়।

---

# ডিজাইন প্রিন্সিপাল কেন দরকার? (Why do we need Design Principles?)

ডিজাইন প্রিন্সিপাল ছাড়া তৈরি করা সফটওয়্যার শুরুতে কাজ করলেও, সময় যাওয়ার সাথে সাথে তা "Spaghetti Code" বা জটিল কোডে পরিণত হয়। ডিজাইন প্রিন্সিপাল মেনে কোড লেখার কিছু প্রধান সুবিধা বা প্রয়োজনীয়তা নিচে দেওয়া হলো:

### ১. সহজে ম্যানেজ বা মেইনটেইন করা (Maintainability)
যেকোনো সফটওয়্যার সময়ের সাথে সাথে আপডেট হয়। নতুন ফিচার যোগ করা বা পুরনো বাগ ফিক্স করার সময় ডিজাইন প্রিন্সিপাল মেনে লেখা কোড খুব সহজেই পড়ে বোঝা যায় এবং আপডেট করা যায়।

### ২. বারবার ব্যবহারযোগ্যতা (Reusability)
প্রিন্সিপালগুলো মেনে কোড লিখলে সিস্টেমের বিভিন্ন মডিউল স্বাধীনভাবে কাজ করে। ফলে একই কোড বা কম্পোনেন্ট সিস্টেমের অন্য জায়গায় বা সম্পূর্ণ নতুন প্রোজেক্টেও পুনরায় ব্যবহার করা যায়, যা ডেভেলপমেন্টের সময় বাঁচায়।

### ৩. স্কেলেবিলিটি (Scalability)
ভবিষ্যতে ইউজারের সংখ্যা বাড়লে বা সিস্টেমে বড় ধরনের পরিবর্তন আসলে, একটি ভালো ডিজাইনের সফটওয়্যার ভেঙে পড়ে না। এটি খুব সহজেই প্রসারিত (Scale-up) করা যায়।

### ৪. টিমে কাজ করার সুবিধা (Better Collaboration)
একটি বড় প্রোজেক্টে যখন অনেকজন ডেভেলপার একসাথে কাজ করেন, তখন একটি নির্দিষ্ট স্ট্যান্ডার্ড (যেমন: SOLID principles) মেনে কোড লিখলে সবার জন্যই একে অপরের কোড বোঝা বেশ সহজ হয়।

### ৫. কাপলিং কমানো (Loose Coupling & High Cohesion)
সিস্টেমের কোনো একটি অংশে পরিবর্তন আনলে সেটি যেন অন্য কোনো অংশকে প্রভাবিত না করে (Loose Coupling), তা ডিজাইনের মাধ্যমে নিশ্চিত করা যায়। এটি বাগ (Bug) হওয়ার সম্ভাবনা অনেকাংশে কমিয়ে দেয়।

### ৬. টেস্টিং সহজ করা (Easier Testing)
কোড যদি পরিষ্কার এবং মডিউলার হয়, তবে এর বিভিন্ন অংশের জন্য ইউনিট টেস্ট (Unit Test) লেখা অনেক সোজা হয়। ফলে সফটওয়্যার রিলিজের আগেই ভুলত্রুটি ধরা পড়ে।

---

# একটি খারাপ OOP কোড দেখতে কেমন হয়? (What Does Bad OOP Code Look Like?)

চলুন একটি রিয়েল-লাইফ উদাহরণ দেখা যাক। এই কোডটি অবজেক্ট ওরিয়েন্টেড প্রোগ্রামিং (OOP) এর সাধারণ নিয়ম অনুসরণ করছে — এতে `class` আছে এবং `method` আছে। কিন্তু এর **ডিজাইন সম্পূর্ণ ভুল**। 

পুরো সিরিজ জুড়ে এই `class`-টি আমাদের সাথে থাকবে এবং প্রতিটা পর্বে আমরা একে একটু একটু করে রিফ্যাক্টর (Refactor) করে ঠিক করবো।

## OrderService — "সব আমি একাই করি!"

ধরুন, আপনি একটি ই-কমার্স অ্যাপ তৈরি করছেন। কাস্টমার অর্ডার প্লেস করবে। আপনি যেহেতু OOP জানেন, তাই একটি `OrderService` ক্লাস তৈরি করলেন এবং আলাদা আলাদা মেথডও বানালেন — যেন প্রতিটি মেথড নির্দিষ্ট একটি কাজ করতে পারে:

```csharp
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
```

### আউটপুট (Output):
```text
✅ Order Created!
   Customer: Rahim
   Product: iPhone 15, Quantity: 1
   Total: 150000 TK

💳 Processing payment of 150000 TK via bKash...
   Connecting to bKash API...
   bKash: Payment of 150000 TK successful!

💾 Saving order to database...
   SQL: INSERT INTO Orders VALUES('Rahim', 'iPhone 15', 150000)
   Database: Order saved successfully!

📧 Sending confirmation email...
   SMTP: Connecting to mail server...
   To: rahim@email.com
   Subject: Order Confirmed!
   Body: Dear Rahim, your order for iPhone 15 has been placed.
   Email sent successfully!

📄 Generating invoice PDF...
   Creating: Invoice_Rahim_iPhone 15.pdf
   Adding header, items, total...
   PDF generated successfully!

🎉 Order process complete!
```

---

## সমস্যা কোথায়? (What’s the Problem?)

এই কোডটি তো ঠিকঠাক কাজ করছে এবং আউটপুটও ঠিকমতো আসছে। এতে OOP-এর গঠন (Class, Methods) আছে এবং দেখতেও মন্দ না। তাহলে এর সমস্যা কোথায়?

> [!NOTE]
> **রিয়েল প্রজেক্ট টিপস্ (Real Project Tip):** 
> আমাদের কোডে Price বা Amount-এর হিসাবের জন্য `double` ডেটা টাইপ ব্যবহার করা হয়েছে, যা শুধুমাত্র শেখার সুবিধার জন্য রাখা হয়েছে। 
> রিয়েল প্রোজেক্টে টাকা-পয়সার হিসাবে সব সময় `decimal` ব্যবহার করতে হবে। কারণ `double`-এ ফ্লোটিং পয়েন্ট প্রিসিশন এরর (Floating Point Precision Error) হয়। যেমন: `0.1 + 0.2` হিসাব করলে `0.30000000000000004` এরকম ভুল ফলাফল আসতে পারে, কিন্তু `decimal`-এ এই সমস্যা নেই। এই সিরিজটিতে আমরা কনসেপ্টের উপর জোর দিচ্ছি, তাই আপাতত `double` রাখছি।

**"কিন্তু মেথড তো আলাদা করেছি! প্রতিটা কাজই আলাদা মেথডে হচ্ছে!"**

হ্যাঁ, মেথডগুলো আলাদা, কিন্তু সবগুলো মেথড **একই ক্লাসের** (`OrderService`) ভেতর রাখা হয়েছে! এখানেই ডিজাইনে বড় ধরনের ভুল রয়ে গেছে। চলুন পরের অংশে দেখি এতে আসলে কী কী সমস্যা তৈরি হচ্ছে...
