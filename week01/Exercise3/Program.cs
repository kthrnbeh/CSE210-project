using System;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
    
//Start by asking the user for the magic number. (In future steps, we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)
//Ask the user for a guess.
//Using an if statement, determine if the user needs 
//to guess higher or lower next time, or tell them if they guessed it.
//At this point, you won't have any loops.
       
    //Ask user for a guess
        Console.WriteLine ("Welcome to guess the Magic number game!");
        //Asking user for magic number 
        //Console.Write("Please input a magic number:");
        //int magic = int.Parse(Console.ReadLine());
        //Changed it to random
         //Stretch count the amount of guesses 
        
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,100);
        //ask user to input gress for the number
        Console.Write("Please give me a guess for the magic number?");
        int number= int.Parse(Console.ReadLine());
        //When  the program begins it doesn't tell you higher
        //or lower on the first one. I wonder how to do that. 
        //Check the guess with if statement
        //counting the number of guesses 
        int guessCount = 0;

        while (magic != number)
        {
            //ask user to input gress for the number
            Console.Write("Please give me a guess for the magic number?");
            number= int.Parse(Console.ReadLine());
            
            if (magic==number)
            {
                Console.WriteLine("You did it!");
                guessCount +=1;
            }
            else if ( magic > number)
            {
                Console.WriteLine("Higher!");
                guessCount +=1;

            }
            else
            {
                Console.WriteLine("Lower!");
                guessCount +=1;
            }
        }
        Console.WriteLine($"You did it. It took you {guessCount} tries to guess.");
   }



}

// I tried stretch challenge, I could get the counter to work
//but not the yes to work. Maybe I will look up a tutoral. 