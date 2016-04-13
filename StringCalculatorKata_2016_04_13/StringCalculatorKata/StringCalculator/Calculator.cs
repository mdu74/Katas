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

                int sum = int.Parse(stringOfNumbers[0]) + int.Parse(stringOfNumbers[1]);

                return sum; 

            }
            return int.Parse(numbers);

        }
    }
}
