using System;
using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void returns_number_itself_when_not_divided_by_3_or_5(int input, string expected)
        {
            var actual = FizzBuzzGenerator.Generate(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void returns_fizz_on_numbers_that_are_divided_by_3(int input)
        {
            const string expected = "fizz";

            var actual = FizzBuzzGenerator.Generate(input);

            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]

        public void returns_buzz_on_numbers_that_are_divided_by_5(int input)
        {
            const string expected = "buzz";

            var actual = FizzBuzzGenerator.Generate(input);

            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void returns_fizzbuzz_on_numbers_that_are_divided_by_5_and_3(int input)
        {
            const string expected = "fizzbuzz";

            var actual = FizzBuzzGenerator.Generate(input);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
