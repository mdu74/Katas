using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            var delimiters = new List<string> { ",", "\n" }; 
            if (numbers.StartsWith("//"))
            {
                var indexOfNewLine = numbers.IndexOf("\n");
                delimiters.AddRange(
                    numbers.Substring(0, indexOfNewLine)
                    .Replace("//","")
                    .Split(new []{'[', ']'}, StringSplitOptions.RemoveEmptyEntries));
                numbers = numbers.Substring(indexOfNewLine + 1);
            }
            var stringOfNumbers = SplitDelimiters(numbers, delimiters);
            CheckNegative(stringOfNumbers);
            return SumCalculator(stringOfNumbers);
        }

        private static string[] SplitDelimiters(string numbers, List<string> delimiters)
        {
            return numbers.Split(delimiters.ToArray(), StringSplitOptions.None);
        }

        private static int SumCalculator(string[] stringOfNumbers)
        {
            return stringOfNumbers.Where(items => int.Parse(items) <= 1000).Sum(items => int.Parse(items));
        }

        private static void CheckNegative(string[] stringOfNumbers)
        {
            var negatives = stringOfNumbers.Where(n => int.Parse(n) < 0);

            if (negatives.Any())
            {
                throw new ApplicationException("Negatives not allowed : " + string.Join(",", negatives));
            }
        }
    }
}
