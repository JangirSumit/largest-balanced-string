using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Balanced_String
{
    public class CalculateBalancedString
    {
        private readonly ICheckBalancedString checkBalancedString = null;

        public CalculateBalancedString(ICheckBalancedString checkBalancedString)
        {
            this.checkBalancedString = checkBalancedString;
        }

        public int GetBalancedStringCount(string inputString)
        {
            return this.checkBalancedString.CountBalancedStrings(inputString);
        }
    }
}
