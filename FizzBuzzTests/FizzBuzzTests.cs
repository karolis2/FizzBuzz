using FluentAssertions;
using static FizzBuzzService.FizzBuzzService;

namespace FizzBuzzTests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(1358)]
    [InlineData(513)]
    [InlineData(81)]

    public void Should_ReturnFizz_When_InputIsDivisibleByThree(int integer)
    {
        CheckIfIntegerDivisibleByThreeOrFiveAndReturnResult(integer).Should().Be("Fizz");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(50)]
    [InlineData(200)]
    [InlineData(155)]
    [InlineData(85)]

    public void Should_ReturnBuzz_When_InputIsDivisibleByFive(int integer)
    {
        CheckIfIntegerDivisibleByThreeOrFiveAndReturnResult(integer).Should().Be("Buzz");
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    [InlineData(90)]
    [InlineData(105)]

    public void Should_ReturnFizzBuzz_When_InputIsDivisibleByFive_And_DivisibleByThree(int integer)
    {
        CheckIfIntegerDivisibleByThreeOrFiveAndReturnResult(integer).Should().Be("FizzBuzz");
    }
}