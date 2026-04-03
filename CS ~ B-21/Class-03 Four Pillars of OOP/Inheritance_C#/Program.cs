
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
        Console.WriteLine($"Name: {Name}, Id: {Id}");
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

public class Student : Person
{
    public double Marks;
    public Student(string name, int id, double marks) : base(name, id)
    {
        this.Marks = marks;
    }
    public void ShowAll()
    {
        base.PrintInfo();
        Console.WriteLine($"Marks: {Marks}");
    }

    public string GetGrade()
    {
        if (Marks >= 80) return "A+";
        else if (Marks >= 60) return "A";
        else if (Marks >= 40) return "B";
        else return "F";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Rahim", 101, 85);
        // student1.Name = "Rahim";
        // student1.Id = 101;
        // student1.Marks = 85;

        student1.ShowAll();
        Console.WriteLine($"Grade: {student1.GetGrade()}");
    }
}