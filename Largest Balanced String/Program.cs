using System;
using System.Collections.Generic;

namespace Largest_Balanced_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            List<string> inputString = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                Console.WriteLine(new CheckBalancedString().CountBalancedStrings(Console.ReadLine()));
            }

            Console.ReadLine();
        }
    }
}
