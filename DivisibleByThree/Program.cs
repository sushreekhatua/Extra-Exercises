// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Divisible_by_3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Let's findout count of numbers between 1 and 100,which are divisible by 3 with no remainder");
            int count=0;
            for(int i=1; i<=100; i++)
            {
                if(i%3==0)
                {
                    count++;
                }   
            }
            System.Console.WriteLine("The count is :{0}",count);
        }
    }
}
