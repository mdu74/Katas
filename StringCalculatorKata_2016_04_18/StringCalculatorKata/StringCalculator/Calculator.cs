using System.Runtime.InteropServices.ComTypes;

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
