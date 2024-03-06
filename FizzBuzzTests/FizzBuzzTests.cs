using FluentAssertions;
using static FizzBuzzService.FizzBuzzService;

namespace FizzBuzzTests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(135)]
    [InlineData(513)]
    [InlineData(81)]

    public void Should_ReturnFizz_When_InputIsDivisibleByThree(int integer)
    {
        CheckIfIntegerDivisibleByThreeOrFiveAndReturnResult(integer).Should().Be("Fizz");
    }
}