using System;

namespace CalculatorConsoleApp
{
    public class Program
    {
        public static string Operator { get; set; }

        public static void Main(string[] args)
        {
            Operator = args[0];
            
            Console.WriteLine("Hello World!");

        }
    }
}
