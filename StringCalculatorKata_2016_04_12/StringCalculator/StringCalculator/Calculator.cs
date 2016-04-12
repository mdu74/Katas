using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Replace("//", "");
                numbers = numbers.Substring(2);
            }
            
            return SumCalculation(numbers);
        }

    
        private static int SumCalculation(string numbers)
        {
            var stringOfNumbers = numbers.Split(new[] { '\n', ',', ';' });
            CheckNegative(stringOfNumbers);
            int sum = 0;
            foreach (string items in stringOfNumbers)
            {
                sum += int.Parse(items);
            }

            return sum;
        }

        private static void CheckNegative(string[] stringOfNumbers)
        {
            var negatives = stringOfNumbers.Where(n => int.Parse(n) < 0);

            if (negatives.Any())
            {
                throw new ApplicationException("Negatives Not Allowed");
            }
        }
    }
}
