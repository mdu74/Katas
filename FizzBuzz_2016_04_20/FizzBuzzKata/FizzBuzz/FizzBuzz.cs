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
            if (int.Parse(input)%3 == 0)
            {
                return "Fizz";
            }
            if (input == "5")
            {
                return "Buzz";
            }

            return input;
        }
    }
}
