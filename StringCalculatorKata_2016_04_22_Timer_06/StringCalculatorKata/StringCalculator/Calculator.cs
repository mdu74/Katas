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
            var delimiters = new List<string> { ",", "\n" };
            if (numbers.StartsWith("//"))
            {
                var indexOfNewList = numbers.IndexOf('\n');
                delimiters.AddRange(numbers.Substring(0, indexOfNewList).Replace("//","").Split(new []{'[',']'}));
                //numbers = numbers.Replace("//", "");
                //numbers = numbers.Substring(2);
                numbers = numbers.Substring(indexOfNewList + 1);
            }

            var stringOfNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);

            CheckForNegativeNumbers(stringOfNumbers);

            return stringOfNumbers.Where(items => int.Parse(items) <= 1000).Sum(items => int.Parse(items));
        }

        private static void CheckForNegativeNumbers(string[] stringOfNumbers)
        {
            var negatives = stringOfNumbers.Where(n => int.Parse(n) <= 0);
            if (negatives.Any())
            {
                throw new Exception("Negatives not allowed");
            }
        }
    }
}
