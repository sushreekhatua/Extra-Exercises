// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

/*
Write a program and ask the user to enter a time value in the 24 hour time format (e.g. 19:00).
 A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
 display "Invalid Time".IF the user doesn't provide any values, consider it as invalid time.
 */

namespace ValidTimeRange // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a time value in the 24 hour time format (e.g. 19:00)");
            string time1=Console.ReadLine();
            if(string.IsNullOrWhiteSpace(time1))
            {
                System.Console.WriteLine(" You entered a invalid time.");
            }

            else
            {
                int hour=int.Parse(time1 ? .Split(":")[0].Trim());
                // We can use if clause after split to check the length of the string to avoid the exception e.g var x=time1.Split(":") and x.Legth
                
                int minute=int.Parse(time1 ? .Split(":")[1].Trim());


                if((hour>=0 && hour<=23) && (minute>=0 && minute<=59))
                {
                    System.Console.WriteLine("You have entered a valid time range.");
                }
                else
                {
                    System.Console.WriteLine("You have entered an invalid time range.");
                }
            }
        }
    }
}
