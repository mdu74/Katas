using System.Globalization;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string input)
        {
            if (input == "")
            {
                return 0;
            }

                var stringOfNumbers = input.Split(',');

                var sum = 0;

                foreach (string items in stringOfNumbers)
                {
                    sum += int.Parse(items);
                }

                return sum;
            }
        
    }
}