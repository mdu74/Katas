
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
            var delimiter = new Line
            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Replace("//", "");
                numbers = numbers.Substring(2);
            }
            
            var stringOfNumbers = numbers.Split(',', '\n', ';');
            var negatives = stringOfNumbers.Where(n => int.Parse(n) < 0);
            if (negatives.Any())
            {
                throw new ApplicationException("Negatives not allowed");
            }

            return stringOfNumbers.Where(items=>int.Parse(items)<=1000).Sum(items=>int.Parse(items));
        }
    }
}
