// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

/*
Write a program and ask the user to enter a few numbers separated by a hyphen. 
If the user simply presses ENTER, without supplying any input, exit immediately; 
otherwise, check to see if there are dulicates.
 If so, display "Duplicate" on the console.
 */

namespace FindDuplicate 
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter few numbers separated by hyphen.");
            var s=Console.ReadLine();
            var s1=s.Split("-").Select(x => int.Parse(x.Trim())).ToList();
            System.Console.WriteLine("This has {0}.",((s1.GroupBy(x => x).Any( i => i.Count()>1)) ? "duplicates" : "No duplicates"));    
        }    
    }
}
