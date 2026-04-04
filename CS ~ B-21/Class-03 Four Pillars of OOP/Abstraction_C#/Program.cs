using System;

public interface IPerson
{
    void PrintInfo();
}

public interface IExportable
{
    void ExportToFile(string filename);
}

public class Student : IPerson, IExportable
{
    public string Name;
    public int Id;
    public double Marks;

    public Student(string name, int id, double marks)
    {
        this.Name = name;
        this.Id = id;
        this.Marks = marks;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}, Marks: {Marks}");
    }

    public void ExportToFile(string filename)
    {
        Console.WriteLine($"Exporting {Name}'s data to {filename}...");
    }
}

public class Teacher : IPerson
{
    public string Name;
    public int Id;
    public string Subject;

    public Teacher(string name, int id, string subject)
    {
        this.Name = name;
        this.Id = id;
        this.Subject = subject;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}, Subject: {Subject}");
    }
}

class Program
{
    static void Main()
    {
        Student rahim = new Student("Rahim", 101, 85);
        Teacher karim = new Teacher("Karim", 201, "Mathematics");

        // Interface — IPerson
        rahim.PrintInfo();
        karim.PrintInfo();

        Console.WriteLine("---");

        // Interface type variable — polymorphism
        IPerson[] people = new IPerson[] { rahim, karim };
        foreach (IPerson p in people)
        {
            p.PrintInfo();
        }

        Console.WriteLine("---");

        // Multiple Interface — IExportable (Student only)
        rahim.ExportToFile("rahim_data.txt");
    }
}