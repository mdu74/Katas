﻿
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

            var stringOfNumbers = numbers.Split(',');

            var sum = 0;

            foreach (var items in stringOfNumbers)
            {
                sum += int.Parse(items);
            }

            return sum;
        }
    }
}
