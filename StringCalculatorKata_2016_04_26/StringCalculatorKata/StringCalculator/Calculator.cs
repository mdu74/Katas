using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using NUnit.Framework;

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

            var delimiters = new List<string> { ",", "\n", ";" };
            if (numbers.StartsWith("//"))
            {
                var indexOfNewLines = numbers.IndexOf('\n'); 
                delimiters.AddRange(numbers.Substring(0, indexOfNewLines).Replace("//", "").Split(new []{ '[', ']' }));
                //numbers = numbers.Replace("//", "");
                //numbers = numbers.Substring(2);
                numbers = numbers.Substring(indexOfNewLines + 1);
            }

            var stringOfNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            
            var negatives = stringOfNumbers.Where(n => int.Parse(n) < 0);
            if (negatives.Any())
            {
                throw new Exception("Negatives not allowed");
            }

            return stringOfNumbers.Where(items=>int.Parse(items)<=1000).Sum(items=>int.Parse(items));
        }
    }
}
