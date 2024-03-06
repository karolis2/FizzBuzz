using FizzBuzzService.FizzBuzzEnums;

namespace FizzBuzzService;

public class FizzBuzzService
{
    public static string CheckIfIntegerDivisibleByThreeOrFiveAndReturnResult(int integer)
    {
        var numberIsDivisibleByThree = integer % 3 == 0;
        var numberIsDivisibleByFive = integer % 5 == 0;

        var result = integer.ToString();

        if (numberIsDivisibleByThree && numberIsDivisibleByFive)
        {
            result = FizzBuzzConstants.FizzBuzz;
        }
        else if (numberIsDivisibleByThree)
        {
            result = FizzBuzzConstants.Fizz;
        }
        else if (numberIsDivisibleByFive)
        {
            result = FizzBuzzConstants.Buzz;
        }

        return result;
    }
}