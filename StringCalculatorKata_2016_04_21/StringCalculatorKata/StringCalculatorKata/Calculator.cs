using System;
using System.Linq;
using NUnit.Framework;

namespace StringCalculatorKata
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
            var sum = 0;
            var stringOfNumbers = numbers.Split(new[] { ';', ',', '\n' });

            var negatives = stringOfNumbers.Where(n=>int.Parse(n)<0);
            if (negatives.Any())
            {
                throw new ApplicationException("Negatives not allowed");
            }

            foreach (var items in stringOfNumbers)
            {
                sum += int.Parse(items);
            }
            return stringOfNumbers.Where(items => int.Parse(items) <= 1000).Sum(items => int.Parse(items));
        }
    }
}
