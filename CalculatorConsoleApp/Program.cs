using System;

namespace CalculatorConsoleApp
{
    public class Program
    {
        public static string Operator { get; set; }

        public static void Main(string[] args)
        {
            
            foreach (string row in args)
            {
                Operator = args[row];
            }
            
            Console.WriteLine("Hello World!");

        }
    }
}
