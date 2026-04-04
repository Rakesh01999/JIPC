using System;

public class Person
{
    public string Name;
    public int Id;

    public Person(string name, int id)
    {
        this.Name = name;
        this.Id = id;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}");
    }

    // Overloaded version
    public void PrintInfo(bool showDetailed)
    {
        if (showDetailed)
            Console.WriteLine($"[DETAILED] Name: {Name}, ID: {Id}, Type: Person");
        else
            Console.WriteLine($"Name: {Name}, ID: {Id}");
    }
}

public class Student : Person
{
    public double Marks;

    public Student(string name, int id, double marks)
        : base(name, id)
    {
        this.Marks = marks;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}, Marks: {Marks}");
    }
}

public class Teacher : Person
{
    public string Subject;

    public Teacher(string name, int id, string subject)
        : base(name, id)
    {
        this.Subject = subject;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}, Subject: {Subject}");
    }
}

class Program
{
    static void Main()
    {
        // Runtime Polymorphism — override
        Person[] people = new Person[]
        {
            new Student("Rahim", 101, 85),
            new Teacher("Karim", 201, "Mathematics"),
            new Student("Fatima", 102, 92)
        };

        foreach (Person p in people)
        {
            p.PrintInfo();
            Console.WriteLine("---");
        }

        // Compile-Time Polymorphism — overloading
        Person rahim = new Person("Rahim", 101);
        rahim.PrintInfo();          // parameter ছাড়া version
        rahim.PrintInfo(true);      // parameter সহ version — detailed
    }
}
