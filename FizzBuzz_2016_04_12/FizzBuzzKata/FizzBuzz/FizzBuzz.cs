
namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string IsFizzBuzz(string input)
        {
            if (IsDivisibleByThree(input) && IsDivisibleByFive(input))
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

        private static bool IsDivisibleByFive(string input)
        {
            return int.Parse(input) % 5 == 0;
        }

        private static bool IsDivisibleByThree(string input)
        {
            return int.Parse(input) % 3 == 0;
        }
    }
}
