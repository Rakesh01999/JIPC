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

    public void PrintInfo()
    {
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

    public string GetGrade()
    {
        if (Marks >= 80) return "A+";
        else if (Marks >= 60) return "A";
        else if (Marks >= 40) return "B";
        else return "F";
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

    public string GetTitle()
    {
        return $"{Name} Sir ({Subject})";
    }
}

class Program
{
    static void Main()
    {
        Student rahim = new Student("Rahim", 101, 85);
        Teacher karim = new Teacher("Karim", 201, "Mathematics");

        // Student — Person-এর সব + নিজের extra
        rahim.PrintInfo();                    // Person থেকে পাওয়া
        Console.WriteLine(rahim.Marks);       // Student-এর নিজের
        Console.WriteLine(rahim.GetGrade());  // Student-এর নিজের

        Console.WriteLine("---");

        // Teacher — Person-এর সব + নিজের extra
        karim.PrintInfo();                    // Person থেকে পাওয়া
        Console.WriteLine(karim.Subject);     // Teacher-এর নিজের
        Console.WriteLine(karim.GetTitle());  // Teacher-এর নিজের
    }
}