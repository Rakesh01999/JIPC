using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey, bro !");
        // int age = 50;
        // if(age >= 18)
        //     Console.WriteLine("You are adult.");
        // else if(age >= 13)
        //     Console.WriteLine("You are teenager.");
        // else
        //     Console.WriteLine("You are child.");

        // switch(age)
        // {
        //     case 20:
        //         Console.WriteLine("You are adult.");
        //         break;
        //     case 15:
        //         Console.WriteLine("You are teenager.");
        //         break;
        //     default:
        //         Console.WriteLine("You are child.");
        //         break;
        // }

        // int size = Convert.ToInt32(Console.ReadLine());
        // for(int i = 0; i <= size; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int i = 0;
        // while(i <= 9)
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }

        // int [] numbers = { 5, 3, 8, 1, 4};
        // Console.WriteLine("Before sorting:");
        // foreach(int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        // Array.Sort(numbers);
        // Console.WriteLine("After sorting:");
        // foreach(int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        // string name1 = "John";
        // string name2 = "Jane";
        // bool areEqual = name1.Equals(name2);
        // Console.WriteLine($"Are the names equal? {areEqual}");

        List<int> numbers = new List<int> { 5, 3, 8, 1, 4 };
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        Console.WriteLine("Numbers in the list:");
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }

    }

}
