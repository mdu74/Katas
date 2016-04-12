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

            if (numbers.Contains(","))
            {
                var stringOfNumbers = numbers.Split(',');
                int sum = 0;
                foreach (string items in stringOfNumbers)
                {
                    sum += int.Parse(items);
                }
                return sum;
            }

            if (numbers.Contains(","))
            {
                var stringOfNumbers = numbers.Split(',');

                var sum = int.Parse(stringOfNumbers[0]) + int.Parse(stringOfNumbers[1]);
                
                return sum;
            }
            
            return int.Parse(numbers);
        }
    }
}
