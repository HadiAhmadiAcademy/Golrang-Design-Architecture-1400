using System;

namespace FizzBuzz
{
    public static class FizzBuzzGenerator
    {
        public static string Generate(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return "fizzbuzz";
            if (number % 5 == 0) return "buzz";
            if (number % 3 == 0) return "fizz";

            return number.ToString();
        }
    }
}
