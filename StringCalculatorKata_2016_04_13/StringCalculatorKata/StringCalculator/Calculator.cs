using System;
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

            var stringOfNumbers = numbers.Split(new []{';', '\n', ',' });

            CheckIfNegative(stringOfNumbers);

            return NumberSum(stringOfNumbers);
        }

        private static int NumberSum(string[] stringOfNumbers)
        {
            var sum = 0;
            foreach (var items in stringOfNumbers)
            {
                sum += int.Parse(items);
            }

            return sum;
        }

        private static void CheckIfNegative(string[] stringOfNumbers)
        {
            var negatives = stringOfNumbers.Where(n => int.Parse(n) < 0);

            if (negatives.Any())
            {
                throw new ApplicationException("negative not allowed");
            }
        }
    }
}
