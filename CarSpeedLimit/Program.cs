// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter the speed limit.
            System.Console.Write("Enter the speed limit of car: ");
            int speedlimit=int.Parse(Console.ReadLine());
           

            //Ask for the speed of a car
            System.Console.Write("Enter the speed of car: ");
            int carspeed=int.Parse(Console.ReadLine());
            

            System.Console.WriteLine($"\nThe speed limit for car is {speedlimit} km/h.");
            System.Console.WriteLine($"The speed of car is {carspeed} km/h.");

            /*If the user enters a value less than the speed limit, 
            program should display Ok on the console. If the value is above the speed limit,
             the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 
             1 demerit points should be incurred and displayed on the console. 
            If the number of demerit points is above 12, the program should display License Suspended.
            */
            calculatespeed(carspeed,speedlimit);
        }

        public static void calculatespeed(int carspeed,int speedlimit)
        {
            if (carspeed< speedlimit)
            {
                System.Console.WriteLine("OK");
            }
            else
            {    
                int diff=carspeed-speedlimit;
                int demeritpoint=diff/5;
                System.Console.WriteLine("The total number of demeritpoint is :{0}",demeritpoint);
                if(demeritpoint>12)
                {
                    System.Console.WriteLine("License Suspended!");
                }
                System.Console.WriteLine("Your speed is not ok.Drive Slowly.");

            }
        }
    }
}
