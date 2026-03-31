using System;

public class Student
{
    public string Name;
    public int Roll;
    public double Bengali;
    public double English;
    public double Math;

    // public Student()
    // {
    //     Console.WriteLine("Student object created.");
    // }

    public Student(string name, int roll, double bengali, double english, double math )
    {
        Name = name;
        Roll = roll;
        Bengali = bengali;
        English = english;
        Math = math;
    }

    public void printStudentInfo()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Roll: {Roll}");
        Console.WriteLine($"Bengali: {Bengali}");
        Console.WriteLine($"English: {English}");
        Console.WriteLine($"Math: {Math}");
    }

    public double calculateAverage()
    {
        return (Bengali + English + Math) / 3;
    }
}

public class Greeting
{
    public Greeting(string name)
    {
        name = name;
        Console.WriteLine($"Hello, {name}! Welcome to the OOP with C# !");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Student student1 = new Student();
        // Greeting greeting = new Greeting("Rahim");
        // student1.Name = "Rahim";
        // student1.Roll = 20;
        // student1.Bengali = 85.5;
        // student1.English = 90.0;
        // student1.Math = 95.5;
        // Console.WriteLine($"Name: {student1.Name}");
        // Console.WriteLine("Roll: " +student1.Roll);
        // Console.WriteLine("Bengali: " + student1.Bengali);
        // Console.WriteLine($"English: {student1.English}");
        // Console.WriteLine($"Math: {student1.Math}");

        Student student2 = new Student("Karim", 22, 86.5, 89.34, 93.01);
        Student student3 = new Student("Asif", 23, 87.0, 88.5, 92.0);
        student2.printStudentInfo();
        student3.printStudentInfo();
    }
}