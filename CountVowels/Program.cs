// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

/*
Write a program and ask it to enter an English word. Count the nunber of vowels (a, e, i, o, u) in the word.
So, if the user enters "inadequate", the program should display 6 in the console.
*/
namespace CountVowels // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter an English word to count the number of vowels in the entered words.");
            string word=Console.ReadLine();
            int count1=0;
            for(int i=0; i<word.Length;i++)
            {
                var v=Convert.ToChar(word[i]);
                if(v=='a'|| v=='e' || v=='i' || v=='o'|| v=='u')
                {
                    count1++;
                }

            }
            Console.WriteLine($"The number of vowels present in the entered words are :{count1}");
        }
    }
}

