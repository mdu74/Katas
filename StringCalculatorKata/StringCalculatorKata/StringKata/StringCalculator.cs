using System.Runtime.Remoting.Messaging;
using NUnit.Framework.Constraints;

namespace StringKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            if (numbers.Contains(","))
            {
                var stringOfNumbers = numbers.Split(',');
                return int.Parse(stringOfNumbers[0]) + int.Parse(stringOfNumbers[1]);
            }
            

            return int.Parse(numbers);
        }

    }
}
