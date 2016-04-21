using System;

namespace StringCalculatorKata
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
                return sum;

            }
            return int.Parse(numbers);
        }
    }
}
