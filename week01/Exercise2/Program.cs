using System;
using System.Runtime.CompilerServices;

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
        // Stretch challenge add + or -
        // stretch save the sign into a variable
        string letter = ""; // adding a varible named letter 
        string sign = "";
        
        if (one >= 90)
        {   letter ="A";
            //if(one >=97) // This was my idea for the stretch challenge,
            //I couldn't figure out how to do the other one without help
            //{
            //    letter ="A+";
            //}
            //else if (one >= 93)
            //{
            //     letter = "A-";
            //}
        }
        else if (one >=80)
        {   
                letter ="B";
                // saw from your example they didn't need parthesis
                //if (one >=87)
                //{
                //    letter ="B+";
                //}
                //else if (one >=3)
                //{
                //    letter ="B-";
//
                //}

        }
        else if (one >=70)
        {   
                letter ="C"; // wasn't working until I took parathesis off
                // if (one >=77)
                //{
                //    letter ="C+";
                //}
                //else if (one >=73)
                //{
                //    letter ="C- ";

               // }
        }

        else if (one >=60)
        {   
               letter ="D";
              //  if (one >=67)
              //  {
              //      letter ="D+";
              //  }
              //  else if (one >=63)
              //  {
              //      letter =" D-";

              //  }
        }
        else
        {   
                letter ="F"; 
            
        }
        // with help for the stretch challenge I got
        int otherNumber = one %10;
        if (otherNumber >=7)
        {
            sign="+";
            
        }

        else if (otherNumber >=3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        //Got help with this one too
        if (letter == "A" && sign =="+")
        {
            sign ="";
        }
        if (letter == "F")
        {
            sign = "";
        }
        Console.WriteLine ($"Your grade is:{sign} {letter}");
        if (one >=70)
        {
            Console.WriteLine ("You did it! You passed");
        }
        else
            Console.WriteLine("Try again! Don't give up.");
    }
}

