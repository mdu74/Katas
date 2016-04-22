using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            if (numbers.Contains(","))
            {
                var sum = 0;
                var stringOfNumbers = numbers.Split(',', '\n');
                foreach (var items in stringOfNumbers)
                {
                    sum += int.Parse(items);
                }
                var negatives = stringOfNumbers.Where(n => int.Parse(n) < 0);
                if (negatives.Any())
                {
                    throw new ApplicationException("Negatives not allowed");
                }
                return sum;
            }

            return int.Parse(numbers);
            
        }
    }
}
