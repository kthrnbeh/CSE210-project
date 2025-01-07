using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
    
        // Program to show grade percentages and letter grades
        // if,else if, else, ==, !=, >=, <=, &&,||,! #all signs that can be used
        //ask the user for their grade level
    
        Console.Write("What is your grade percetange?");
        string valueFromUser= Console.ReadLine();
        int one = int.Parse(valueFromUser); //like from the video

    
        if (one >= 90)
        {   
                Console.Write("A");
        }
        else if (one >=80)
        {   
                Console.Write("B");
        }
        else if (one >=70)
        {   
                Console.Write("C");
        }
        else if (one >=60)
        {   
                Console.Write("D");
        }
        else
        {   
                Console.Write("F");
        }
    }
}