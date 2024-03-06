using FizzBuzzService.FizzBuzzEnums;

namespace FizzBuzzService;

public class FizzBuzzService
{
    public static string CheckIfIntegerDivisibleByThreeOrFiveAndReturnResult(int integer)
    {
        var numberIsDivisibleByThree = integer % 3 == 0;
        var numberIsDivisibleByFive = integer % 5 == 0;

        if (numberIsDivisibleByThree && numberIsDivisibleByFive)
        {
            return FizzBuzzConstants.FizzBuzz;
        }

        if (numberIsDivisibleByThree)
        {
            return FizzBuzzConstants.Fizz;
        }

        if (numberIsDivisibleByFive)
        {
            return FizzBuzzConstants.Buzz;
        }

        return integer.ToString();
    }
}