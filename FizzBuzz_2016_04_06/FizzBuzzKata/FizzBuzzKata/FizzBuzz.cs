using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string IsFizzBuzz(string input)
        {
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
