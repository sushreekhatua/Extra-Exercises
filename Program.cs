using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("hi"+" sadhana");
            var man='D';
            Console.WriteLine(man);
            List<int>sadhana=new List<int>{34,76,89};
            foreach (var item in sadhana)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
