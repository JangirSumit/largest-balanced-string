using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_Balanced_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                var input = Console.ReadLine().Trim();
                Dictionary<char, int> keyValuePairs = new Dictionary<char, int>
                {
                    { '(', input.Count(a => a == '(') },
                    { '{', input.Count(a => a == '{') },
                    { '[', input.Count(a => a == '[') },
                    { ')', input.Count(a => a == ')') },
                    { '}', input.Count(a => a == '}') },
                    { ']', input.Count(a => a == ']') }
                };

                int total = Math.Min(keyValuePairs.ContainsKey('(') ? keyValuePairs['('] : 0, keyValuePairs.ContainsKey(')') ? keyValuePairs[')'] : 0) +
                                Math.Min(keyValuePairs.ContainsKey('{') ? keyValuePairs['{'] : 0, keyValuePairs.ContainsKey('}') ? keyValuePairs['}'] : 0) +
                                    Math.Min(keyValuePairs.ContainsKey('[') ? keyValuePairs['['] : 0, keyValuePairs.ContainsKey(']') ? keyValuePairs[']'] : 0);

                Console.WriteLine(total * 2);
            }
            Console.ReadLine();
        }
    }
}
