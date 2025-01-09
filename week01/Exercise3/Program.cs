using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
    }
}//Start by asking the user for the magic number. (In future steps, we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)
//Ask the user for a guess.
//Using an if statement, determine if the user needs 
//to guess higher or lower next time, or tell them if they guessed it.
//At this point, you won't have any loops.
    {    //Ask user for a guess
        Console.WriteLine ("Welcome to guess the Magic number game!");
        Console.Write("Please input a magic number:");
        string magic = Console.ReadLine
        Console.Write("Please give me a guess for the magic number?");
        string number =Console.ReadLine();
        if (magic==number)
        {
            Console.WriteLine("You did it!");
            Console.ReadLine();
        }
        else if ( magic > number)
        {
            Console.WriteLine("Higher!");
            Console.ReadLine();
        }
        else if ( magic < number)
        {
            Console.WriteLine("Lower!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Wrong input, try again.");
            Console.ReadLine();
        }

    }