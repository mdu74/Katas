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
            if (int.Parse(input) % 3 == 0 && int.Parse(input) % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (int.Parse(input)%3 == 0)
            {
                return "Fizz";
            }

            if (int.Parse(input)%5 == 0)
            {
                return "Buzz";
            }

            
            return input;
        }
    }
}
