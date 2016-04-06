using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string IsFizzBuzz(string input)
        {
            if(int.Parse(input) == 3)
            {
                return "Fizz";
            }
            if (int.Parse(input) == 5)
            {
                return "Buzz";
            }
            return input;

        }
    }
}
