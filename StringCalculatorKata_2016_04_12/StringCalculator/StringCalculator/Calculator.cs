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
                foreach(string items in stringOfNumbers)
                {
                    sum += int.Parse(items);
                }
                return sum;

            }
            return int.Parse(numbers);
        }
    }
}
