﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (numbers=="")
            {
                return 0;
            }

            var delimiters = new List<string> { ",", "\n"};
            if (numbers.StartsWith("//"))
            {
                var indexOfNewLine = numbers.IndexOf('\n');
                delimiters.AddRange(numbers.Substring(0, indexOfNewLine).Replace("//","").Split(new []{'[',']'},StringSplitOptions.RemoveEmptyEntries));
                numbers = numbers.Substring(indexOfNewLine + 1);
            }

            var stringOfNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);
            CheckNegativeNumbers(stringOfNumbers);
            return calculateSum(stringOfNumbers);
        }

        private static void CheckNegativeNumbers(string[] stringOfNumbers)
        {
            var negatives = stringOfNumbers.Where(n => int.Parse(n) <= 0);
            if (negatives.Any())
            {
                throw new Exception("Negatives not allowed");
            }
        }

        private static int calculateSum(string[] stringOfNumbers)
        {
            return stringOfNumbers.Where(items => int.Parse(items) <= 1000).Sum(items => int.Parse(items));
        }
    }
}
