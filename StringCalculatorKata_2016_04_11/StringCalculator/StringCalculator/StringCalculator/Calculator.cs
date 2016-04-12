
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
            var stringOfNumbers = numbers.Split(new[] { '\n', ',', ';' });
            
            return SumCalculator(stringOfNumbers);
        }

        private static int SumCalculator(string[] stringOfNumbers)
        {
            var sum = 0;
            foreach (var items in stringOfNumbers)
            {
                sum += int.Parse(items);
            }
            return sum;
        }
    }
}
