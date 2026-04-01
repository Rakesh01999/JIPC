
public class Student
{
    private string Name;
    private int Age;
    private double Bengali;
    private double English;
    private double Math;
    public Student(string name, int age, double bengali, double english, double math)
    {
        Name = name;
        Age = age;
        Bengali = bengali;
        English = english;
        Math = math;
        Console.WriteLine("=============== New Student created =================");
        Console.WriteLine($"Hello {Name}, Welcome to the world of OOP !");
    }
    private double GetAverage()
    {
        double average = (Bengali + English + Math) / 3;
        return average;
    }
    public void PrintInfo()
    {
        double average = GetAverage();
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Bengali: {Bengali}");
        Console.WriteLine($"English: {English}");
        Console.WriteLine($"Math: {Math}");
        Console.WriteLine($"Average: {average:F4}");
    }
}

public class Program
{
    public static void Main()
    {
        Student student1 = new Student("Rahim", 20, 85.5, 90.0, 91.0);
        // student1.GetAverage();
        student1.PrintInfo();
        // Student student2 = new Student("Karim", 22, 88.0, 92.5, 93.0);
        // student2.PrintInfo();
    }
}