using System.Diagnostics.CodeAnalysis;
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
            
            if (numbers.Contains(","))
            {
                var stringOfNumbers = numbers.Split(',', '\n');
                return SumCalculator(stringOfNumbers);
            }

            return int.Parse(numbers);
        }

        private static int SumCalculator(string[] stringOfNumbers)
        {
            int sum = 0;
            foreach (var items in stringOfNumbers)
            {
                sum += int.Parse(items);
            }
            return sum;
        }
    }
}
