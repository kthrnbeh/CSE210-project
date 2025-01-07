using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Asking the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        
        // Convert input string to an integer for comparison
        int one = int.Parse(valueFromUser); 

        // Grading logic using if-else statements
        if (one >= 90)
        {   
            Console.WriteLine("A");
        }
        else if (one >= 80)
        {   
            Console.WriteLine("B");
        }
        else if (one >= 70)
        {   
            Console.WriteLine("C");
        }
        else if (one >= 60)
        {   
            Console.WriteLine("D");
        }
        else
        {   
            Console.WriteLine("F");
        }
    }
}
