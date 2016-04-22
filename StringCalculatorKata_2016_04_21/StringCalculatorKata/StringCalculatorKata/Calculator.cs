using System;
using System.Collections.Generic;
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
            var delimiters = new List<string> { ",", "\n" };
            if (numbers.StartsWith("//"))
            {
                var indexOfNewLine = numbers.IndexOf('\n');

                DelimiterManager(numbers, delimiters, indexOfNewLine);

                numbers = numbers.Substring(indexOfNewLine + 1);
            }

            var stringOfNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);

            CheckForNegatives(stringOfNumbers);

            return CheckIfGreaterThanAThousand(stringOfNumbers);
        }

        private static void DelimiterManager(string numbers, List<string> delimiters, int indexOfNewLine)
        {
            delimiters.AddRange(
                numbers.Substring(0, indexOfNewLine)
                    .Replace("//", "")
                    .Split(new[] {'[', ']'},
                        StringSplitOptions.RemoveEmptyEntries));
        }

        private static int CheckIfGreaterThanAThousand(string[] stringOfNumbers)
        {
            return stringOfNumbers.Where(items => int.Parse(items) <= 1000).Sum(items => int.Parse(items));
        }

        private static void CheckForNegatives(string[] stringOfNumbers)
        {
            var negatives = stringOfNumbers.Where(n => int.Parse(n) < 0);
            if (negatives.Any())
            {
                throw new ApplicationException("Negatives not allowed");
            }
        }
    }
}
