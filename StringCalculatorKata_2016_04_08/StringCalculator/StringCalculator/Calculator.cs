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
            
                var stringOfNumbers = input.Split('\n', ',');

                return SumCalAdd(stringOfNumbers);
        }

        private static int SumCalAdd(string[] stringOfNumbers)
        {
            var sum = 0;

            foreach (string items in stringOfNumbers)
            {
                sum += int.Parse(items);
            }

            return sum;
        }
    }
}