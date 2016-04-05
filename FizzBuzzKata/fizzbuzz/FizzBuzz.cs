using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    public class FizzBuzz
    {
        public string IsFizzBuzz(string input)
        {
            if (IsDivisibleByThreeAndFive(input))
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

        private static bool IsDivisibleByThreeAndFive(string input)
        {
            return IsDivisibleByThree(input) && IsDivisibleByFive(input);
        }

        private static bool IsDivisibleByFive(string input)
        {
            return int.Parse(input)%5 == 0;
        }

        private static bool IsDivisibleByThree(string input)
        {
            return int.Parse(input)%3 == 0;
        }
    }
}
