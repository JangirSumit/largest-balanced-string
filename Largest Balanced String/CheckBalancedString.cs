using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_Balanced_String
{
    public interface ICheckBalancedString
    {
        int CountBalancedStrings(string inputString);
    }

    public class CheckBalancedString : ICheckBalancedString
    {
        public int CountBalancedStrings(string inputString)
        {
            int total = 0;
            for (int i = 0; i < inputString.Count(); i++)
            {
                var input = inputString.Trim();
                Dictionary<char, int> keyValuePairs = new Dictionary<char, int>
                {
                    { '(', input.Count(a => a == '(') },
                    { '{', input.Count(a => a == '{') },
                    { '[', input.Count(a => a == '[') },
                    { ')', input.Count(a => a == ')') },
                    { '}', input.Count(a => a == '}') },
                    { ']', input.Count(a => a == ']') }
                };

                total = Math.Min(keyValuePairs.ContainsKey('(') ? keyValuePairs['('] : 0, keyValuePairs.ContainsKey(')') ? keyValuePairs[')'] : 0) +
                                Math.Min(keyValuePairs.ContainsKey('{') ? keyValuePairs['{'] : 0, keyValuePairs.ContainsKey('}') ? keyValuePairs['}'] : 0) +
                                    Math.Min(keyValuePairs.ContainsKey('[') ? keyValuePairs['['] : 0, keyValuePairs.ContainsKey(']') ? keyValuePairs[']'] : 0);

                total *= 2;
            }

            return total;
        }
    }
}
