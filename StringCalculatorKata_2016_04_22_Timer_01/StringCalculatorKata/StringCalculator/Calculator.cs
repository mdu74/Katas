
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
            if (numbers.Contains("//"))
            {
                numbers = numbers.Replace("//", "");
                numbers = numbers.Substring(2);
                
            }

            var sum = 0;
            var stringOfNumbers = numbers.Split(new []{ ',', '\n', ';' });
            foreach (var items in stringOfNumbers)
            {
                sum += int.Parse(items);
            }
            return sum;
        }
    }
}
