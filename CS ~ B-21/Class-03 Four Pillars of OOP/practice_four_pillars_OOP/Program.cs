

public class Student
{
    private string name;
    private int Age;
    private double Bengali;
    private double English;
    private double Math;
    
    // public double getBengali()
    // {
    //     return Bengali;
    // }
    public string Name
    {
        get {return name;}
        set {name = value;}
    }
    public void setBengali(double bengali)
    {
        if (bengali >= 0 && bengali <= 100)
        {
            Bengali = bengali;
        }
        else
        {
            Console.WriteLine("Invalid Bengali marks. Please enter a value between 0 and 100.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name= "";
        Console.WriteLine("Student Name: " + student1.Name);
    }
}