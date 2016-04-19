using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using NUnit.Framework;
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
            
            var delimiters = new List<String> {",","\n"};
            if (numbers.StartsWith("//"))
            {
                var indexOfNewLine = numbers.IndexOf('\n');
                delimiters.AddRange(numbers.Substring(0, indexOfNewLine).Replace("//", "").Split(new []{'[',']'}, StringSplitOptions.RemoveEmptyEntries));
                numbers = numbers.Substring(indexOfNewLine + 1);
            }
            var stringOfNumbers = SplitDelimiters(numbers, delimiters);
            NegativeNumbers(stringOfNumbers);
            return BiggerThanAThousand(stringOfNumbers);

        }

        private static string[] SplitDelimiters(string numbers, List<string> delimiters)
        {
            return numbers.Split(delimiters.ToArray(), StringSplitOptions.None);
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
