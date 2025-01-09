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
        
        // to keep guessing
        string keepGuess= "yes";
        //Stretch count the amount of guesses 
        int guessAmount=0;
     //Originally the loop messed up from the yes
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,100);
            //ask user to input gress for the number
        int number = 0;

    //if say yes they can keep playing 
        while (keepGuess.ToLower() == "yes") // got help with the lower part in fixing my code.
             
            Console.Write("Please give me a guess for the magic number?");
            number= int.Parse(Console.ReadLine());
            guessAmount ++;
            //When  the program begins it doesn't tell you higher
            //or lower on the first one. I wonder how to do that. 
             //Check the guess with if statement
             
             // Apparently needed to move these all to the While look to make the yes work.
        {
            while (magic != number)
           {
                //ask user to input gress for the number
                Console.Write("Please give me a guess for the magic number?");
                number= int.Parse(Console.ReadLine());
                guessAmount += 1;
                //if guess is right.
                if (magic==number)
                {
                    Console.WriteLine("You did it!");

                }
                //if guess needs to be higher.
                else if ( magic > number)
                {
                    Console.WriteLine("Higher!");

                }
                // If the guess is to low.
                else
                {
                    Console.WriteLine("Lower!");

                }

             Console.WriteLine($"The amount of guesses it took was {guessAmount}.");
             Console.WriteLine($"Would you like to keep playing reply yes/no?{keepGuess}");
             keepGuess = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Thanks for playing. Goodbye.");
             }
   }
}