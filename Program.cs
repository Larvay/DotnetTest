using System;
using System.Collections.Generic;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Today;
            int correctNumber = new Random().Next(300) + 1;
            Console.WriteLine($"Now the date is {dt.ToString()}, the random is {correctNumber}");

            var colors = new List<string>() { "blue", "green", "yellow" };
            colors.ForEach(Console.WriteLine);
            Console.WriteLine(String.Join(",", colors));
            Console.WriteLine("Steve");

            Func<int, int> addOne = x => x + 1; // this is the lambda expression
            Console.WriteLine(addOne(4));
        }
    }
}
