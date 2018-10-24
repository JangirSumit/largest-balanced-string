using System;
using System.Collections.Generic;
using Unity;

namespace Largest_Balanced_String
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ICheckBalancedString, CheckBalancedString>();

            CalculateBalancedString calculateBalancedString = unityContainer.Resolve<CalculateBalancedString>();

            var testCases = Convert.ToInt32(Console.ReadLine());
            List<string> inputString = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                Console.WriteLine(calculateBalancedString.GetBalancedStringCount(Console.ReadLine()));
            }

            Console.ReadLine();
        }
    }
}
