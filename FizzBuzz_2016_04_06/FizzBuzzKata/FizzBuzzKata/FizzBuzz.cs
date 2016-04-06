using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string IsFizzBuzz(string input)
        {
            if (IsDivisibleByBothThreeAndFive(input))
            {
                return "FizzBuzz";
            }

            if (IsDivisibleByThree(input))
            {
                return "Fizz";
            }
            
            if (IsDivisibleByFive(input))
            {
                return "Buzz";
            }

            return input;

        }

        private static bool IsDivisibleByBothThreeAndFive(string input)
        {
            return IsDivisibleByThree(input) && IsDivisibleByFive(input);
        }

        private static bool IsDivisibleByThree(string input)
        {
            return int.Parse(input)%3 == 0;
        }

        private static bool IsDivisibleByFive(string input)
        {
            return int.Parse(input)%5 == 0;
        }
    }
}
