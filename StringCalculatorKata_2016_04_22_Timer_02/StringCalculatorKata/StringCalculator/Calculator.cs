using System;
using System.CodeDom;
using System.Diagnostics.CodeAnalysis;

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
                int sum = 0;
                var stringOfNumbers = numbers.Split(',','\n');
                foreach (var items in stringOfNumbers)
                {
                    sum += int.Parse(items);
                }
                return sum;
            }

            return int.Parse(numbers);
        }
    }
}
