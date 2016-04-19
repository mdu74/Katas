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
            
            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Replace("//", "");
                numbers = numbers.Substring(2);
            }

            return SumCalculator(numbers);
        }

        private static int SumCalculator(string numbers)
        {
            var stringOfNumbers = numbers.Split(new []{ ',', '\n', ';' });
            int sum = 0;
            foreach (var items in stringOfNumbers)
            {
                sum += int.Parse(items);
            }
            return sum;
        }
    }
}
