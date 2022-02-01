// See https://aka.ms/new-console-template for more information
/*Write a program and ask the user to enter a few numbers separated by a hyphon. 
Workout if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-17-16",
 display a message: "Consecutive"; otherwise, display "Not-Consecutive".
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ConsecutiveNum // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a few numbers separated by a hyphon.\n");
            var x=Console.ReadLine();
            var list=x.Split("-").Select(x => int.Parse(x.Trim())).ToList();
            System.Console.WriteLine("The elements in the list are :");
            foreach(var i in list)
            {
                System.Console.WriteLine(i);
            }
            string smthng="I don't know";
            
            for(int i=1;i<(list.Count);i++)
            {
                if(list[i]+1==list[i-1] || list[i]-1==list[i-1])
                {
                    smthng="Consecutive";
                }
                else
                {
                    smthng="Non-consecutive";
                    i=list.Count;
                }
            }
            System.Console.WriteLine($"The series you entered are ({smthng}) numbers!!");
            
        }
    }
}