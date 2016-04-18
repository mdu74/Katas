using System;
using System.Linq;

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

            //have a list that will hold your delimiters
            if (numbers.StartsWith("//"))
            {
                //add new delimiters to a list

                //get numbers 
                numbers = numbers.Replace("//","");
                numbers = numbers.Substring(2);
            }
   
            var stringOfNumbers = numbers.Split(new []{'*'}, StringSplitOptions.RemoveEmptyEntries);
            
            CheckIfNegative(stringOfNumbers);

            return NumberSum(stringOfNumbers);
            
        }

        private static int NumberSum(string[] stringOfNumbers)
        {
            return stringOfNumbers.Where(items => int.Parse(items) <= 1000).Sum(items => int.Parse(items));
        }

        private static void CheckIfNegative(string[] stringOfNumbers)
        {
            var negatives = stringOfNumbers.Where(n => int.Parse(n) < 0);

            if (negatives.Any())
            {
                throw new ApplicationException("negative not allowed");
            }
            
        }
    }
}
