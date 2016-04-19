using System.Diagnostics.CodeAnalysis;
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
            
            if (numbers.Contains(","))
            {
                var stringOfNumbers = numbers.Split(',');
                //return int.Parse(stringOfNumbers[0]) + int.Parse(stringOfNumbers[1]);
                int sum = 0;
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
