using System;
using System.Collections.Generic;
using System.Linq;

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
                numbers = numbers.Replace("//","");
                numbers = numbers.Substring(2);
            }

            var stringOfNumbers = numbers.Split(',', '\n', ';').Select(int.Parse);
            var ofNumbers = stringOfNumbers as int[] ?? stringOfNumbers.ToArray();
            CheckForNegativeNumbers(ofNumbers);
            return CalculatorSum(ofNumbers);
            
        }

        private static void CheckForNegativeNumbers(IEnumerable<int> stringOfNumbers)
        {
            var negatives = stringOfNumbers.Where(n => n < 0);
            if (negatives.Any())
            {
                throw new Exception("Negatives not allowed");
            }
        }

        private static int CalculatorSum(IEnumerable<int> stringOfNumbers)
        {
            return stringOfNumbers.Sum();
        }
    }
}
