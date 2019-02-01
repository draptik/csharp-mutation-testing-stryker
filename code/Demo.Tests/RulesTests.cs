using System;
using FluentAssertions;
using Xunit;

namespace Demo.Tests
{
    public class RulesTests
    {
        // Include each `InlineData` line one by one, run `dotnet stryker` and see how it changes the outcome.
        [Theory]
        [InlineData("a", true)]             // -> 3 survive
        [InlineData("", false)]             // -> 2 survive
        [InlineData(null, false)]           // -> 2 survive
        [InlineData("123", true)]           // -> 1 survives
        [InlineData("1234", false)]         // -> 0 survive
        public void ValidationRule_works(string input, bool expected) => 
            new Rules().Validate(input).Should().Be(expected);

        [Theory]
        [InlineData(5, 5, true)]    // addition
        [InlineData(15, 5, true)]   // subtraction
        [InlineData(2, 5, true)]    // multiplication
        [InlineData(20, 2, true)]   // division
        [InlineData(100, 10, true)] // modulo
        [InlineData(1, 1, false)]   // other combinations
        public void AnotherValidation_works(int a, int b, bool expected) =>
            new Rules().AnotherValidation(a, b).Should().Be(expected);
    }
}
