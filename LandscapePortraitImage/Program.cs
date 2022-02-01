// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LandscapePortrait // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("We will define a image is landscape or portrait!!");

           System.Console.WriteLine("Enter the width value:");
           int width=int.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter the height value:");
           int height=int.Parse(Console.ReadLine());
           System.Console.WriteLine(img(width,height));

        }

        public static string img(int width,int height)
        {
            if (width==height){
                return "Both values are same .So it has ratio of 1:1";
            }
            if(width> height)
            {
                return "It is LandScape Image type.";
            }
            else
            {
                return " It is Portrait type.";
            }
        }
    }
}
