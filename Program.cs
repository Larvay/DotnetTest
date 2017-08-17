using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            System.Console.WriteLine(dt.ToShortDateString());
        }
    }
}
