// See https://aka.ms/new-console-template for more information
using System;

namespace RandomNumber // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program that picks a random number between 1 and 10.
             Give the user 4 chances to guess the number.
              If the user guesses the number, display “You won"; otherwise, display “You lost".
             (To make sure the program is behaving correctly, you can display the secret number on the console first).
             */

            System.Console.WriteLine("The secret number is 7!");
            System.Console.WriteLine("Guess a number between 1 to 10 and You have only 4 chances.");

            
            int i=0;
            int count=0;
            while(i<4)
            {        
                int input=int.Parse(Console.ReadLine());
                if(input>=0 && input<=10)
                {

                    if (input==7)
                    {
                        System.Console.WriteLine("You Won!");
                        break;    
                    }
                
                
                    count++;
                    System.Console.WriteLine("Wrong Guess!");
                    if(count<4)
                    {
                        System.Console.WriteLine($"You have {4-count} chance left");
                    }
                    else
                    {
                        System.Console.WriteLine("You lost.....");
                    }


                    i++;
                    System.Console.WriteLine("Enter the number for next chance.");    
            
                }
                else
                {
                    System.Console.WriteLine("You have entered a invalid input... Try Again");
                    continue;
                }
            }     
            
        }
    }
}
