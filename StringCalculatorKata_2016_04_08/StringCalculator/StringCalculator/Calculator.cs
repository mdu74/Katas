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
            if (input.Contains(","))
            {
                var stringOfNumbers = input.Split(',');
                return int.Parse(stringOfNumbers[0]) + int.Parse(stringOfNumbers[1]);
            }
            return int.Parse(input);
        }
        
    }
}