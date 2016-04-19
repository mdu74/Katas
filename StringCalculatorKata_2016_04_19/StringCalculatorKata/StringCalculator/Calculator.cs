using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using NUnit.Framework.Constraints;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }
            
            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Replace("//", "");
                numbers = numbers.Substring(2);
            }
            var stringOfNumbers = numbers.Split(new[] { ',', '\n', ';' });
            NegativeNumbers(stringOfNumbers);
            return BiggerThanAThousand(stringOfNumbers);

        }

        private static void NegativeNumbers(string[] stringOfNumbers)
        {
            var negatives = stringOfNumbers.Where(n => int.Parse(n) < 0);

            if (negatives.Any())
            {
                throw new ApplicationException("Negatives not allowed");
            }
        }

        private static int BiggerThanAThousand(string[] stringOfNumbers)
        {
            return stringOfNumbers.Where(items => int.Parse(items) <= 1000).Sum(items => int.Parse(items));
        }
    }
}
