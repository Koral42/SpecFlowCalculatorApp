using System;
using System.Collections.Generic;

namespace CalculatorConsoleApp
{
    public class Program
    {
        public static string Operator { get; set; }

        public static List<int> numbers = new List<int>();

        public static void Main(string[] args)
        {
            var argLength = args.Length;
            
            //TODO: What happens when no arguements are provided?
            //What Happens when 1000 arguments are provied?
            //What Happens when 5 Billion Arguemts are provied?
            //Bound checking

            Operator = args[0];
            //TODO: What Happens when the Letter T is provided?
            //What Operators should be allowed?

            
            for (int i = 1; i < argLength; i++)
            {
                numbers.Add(int.Parse(args[i]));
                //TODO: what happens if the String is a floating point number?
                //What happens is the string is ' '? 
                //What happens if a string is 100 charaters long
                
            }

        }
    }
}
