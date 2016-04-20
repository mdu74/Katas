using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string IsFizzBuzz(string input)
        {
            if (DivisibleByThree(input) && DivisibleByFive(input))
            {
                return "FizzBuzz";
            }

            if (DivisibleByThree(input))
            {
                return "Fizz";
            }

            if (DivisibleByFive(input))
            {
                return "Buzz";
            }
            
            return input;
        }

        private static bool DivisibleByFive(string input)
        {
            return int.Parse(input)%5 == 0;
        }

        private static bool DivisibleByThree(string input)
        {
            return int.Parse(input)%3 == 0;
        }
    }
}
