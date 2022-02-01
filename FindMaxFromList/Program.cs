// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

/*
Write a program and ask the user to enter a series of numbers separated by comma.
Find the maximum of the numbers and display it on the console. 
For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
*/

namespace FindMaxFromList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize a list
            List<int> newlist=new List<int>{};
           
            while(true)
            {
                System.Console.WriteLine("Enter the number to input the list");
                var a=Console.ReadLine();
                if(a=="" || a=="ok" || a=="done")
                {
                    break;
                }
                else
                {
                    //good to Use try parse 
                    int.TryParse(a , out int x);
                    newlist.Add(x);
                }
                
            }
            System.Console.WriteLine("The elements of the list are : ");
            foreach(var i in newlist)
            {
                System.Console.WriteLine(i);
            }


           int n=newlist.Max();
           System.Console.WriteLine("Highest number is :{0}",n);
            
        }
    }
}

