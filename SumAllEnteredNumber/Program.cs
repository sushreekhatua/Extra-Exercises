// See https://aka.ms/new-console-template for more information
using System;

namespace SumAllNumber // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Let's add all entered number.");
            System.Console.WriteLine("Enter the numbers:");
            bool y=true;
            var sum=0;
            while(y)
            {
                var num=Console.ReadLine();
                if (num=="OK" || num=="" || num.Equals("ok",StringComparison.OrdinalIgnoreCase))
                {
                    y=false;
                }
                else
                {
                    sum=sum+int.Parse(num);
                }
            }
            System.Console.WriteLine("The sum of all entered number is {0}",sum);

        }
    }
}
