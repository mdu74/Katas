using System;
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

            var stringOfNumbers = numbers.Split(new[] { ',', '\n', ';' });
            var negatives = stringOfNumbers.Where(n => int.Parse(n) < 0);

            if (negatives.Any())
            {
                throw new ApplicationException ("Negatives Not Allowed");
            }

            int sum = 0;
            foreach (var items in stringOfNumbers)
            {
                sum += int.Parse(items);
            }
            return sum;
        }
    }
}
