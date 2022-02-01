// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace FindMaxFromList1 // Note: actual namespace depends on the project name.
{
    public class FindMaxlist
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the series of numbers separated by comma (Example: 1,2,3)");
            var x=Console.ReadLine();
            static int findmax(string s)
            {
                var max1=s.Split(",").Select(x => int.Parse(x.Trim())).ToList();
                return max1.Max();
            }
            System.Console.WriteLine("Maximum number is : {0}",findmax(x));


            
        }
    }
}
