// See https://aka.ms/new-console-template for more information
using System;using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ValidNumber // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number between 1 to 10");
            //int num=int.Parse(Console.ReadLine());
            //bool y=(num<1 || num>10);
            //bool y=true;
            while(true)
            {
               int num1= int.Parse(Console.ReadLine());

               if((num1>=1 && num1<=10))
               {
                   //y=false;
                   break;
               }
               Console.WriteLine("YOU HAVE ENTERED A INVALID NUMBER. Please try again!");
               
            }
            System.Console.WriteLine("Well Done!You have entered a valid number.");
            
        }
    }

}
