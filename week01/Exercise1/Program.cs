using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name?" ); // Get first name, keep on the same line
        string questionone=Console.ReadLine(); // 
        Console.Write("What is your last name?" ); // Get last name, keep on same line 
        string questiontwo = Console.ReadLine();
        Console.WriteLine($"Your name is {questiontwo}, {questionone} {questiontwo}"); // Use brackets to add in info
    }
}