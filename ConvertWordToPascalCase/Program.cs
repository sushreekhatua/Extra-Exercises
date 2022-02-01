// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

/*
Write a program and ask the user to enter a few words separated by a space.
Use the words to create a variable name with PascalCase. For example, 
if the user types: "number of students", display "NumberOfStudents". Make sure that the program is
not dependent on the input.So, if the user types "NUMBER OF STUDENTS",
the program should still display "NumberOfStudents".
 */

namespace ConvertWordToPascal // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a few words separated by a space.");
            var s=Console.ReadLine();
            if(string.IsNullOrWhiteSpace(s)) System.Console.WriteLine("Invalid entry!!");
            else
            {
                var words=s.Split(" ").Select(x =>x.Trim().ToLower()).ToArray();

                Console.WriteLine("PascalCased: " + ConvertToPascalCase(words));

            }

            static string ConvertToPascalCase(string[] words)
            {
                if (!words.Any())
                    throw new ArgumentException("Array or List has no elements.");

                var pascaled = "";
                foreach (var word in words)
                    pascaled += CapitalizeFirstLetter(word);

                return pascaled;
            }

            static string CapitalizeFirstLetter(string word)
            {
                if (String.IsNullOrWhiteSpace(word))
                    return string.Empty;
                else
                {
                    var letters = word.ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);

                    return new string(letters);
                }
            
            }
                
                
        }
    }
}
