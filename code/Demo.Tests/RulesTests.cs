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
        // [InlineData("", false)]             // -> 2 survive
        // [InlineData(null, false)]           // -> 2 survive
        // [InlineData("123", true)]           // -> 1 survives
        // [InlineData("1234", false)]         // -> 0 survive
        public void ValidationRule1_works(string input, bool expected) => 
            new Rules().Validate(input).Should().Be(expected);
    }
}
