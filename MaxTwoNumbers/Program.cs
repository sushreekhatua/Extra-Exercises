// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MaxTwoNumber// Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max;
            int min;
            System.Console.WriteLine("Enter two numbers!");

            System.Console.WriteLine("Enter the first number:");
            int x=Int32.Parse(Console.ReadLine());
            

            System.Console.WriteLine("Enter the second number:");
            int y=Int32.Parse(Console.ReadLine());
            

            max=(x>y ? x :y);
            min=(x<y ? x :y);
            System.Console.WriteLine(" The maximum between two number is : {0}",max);

            System.Console.WriteLine(" The minimum between two number is : {0}",min);


            
        }
    }
}
