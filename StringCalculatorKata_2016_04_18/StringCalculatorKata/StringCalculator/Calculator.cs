﻿namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }
            return int.Parse(numbers);
        }
    }
}
