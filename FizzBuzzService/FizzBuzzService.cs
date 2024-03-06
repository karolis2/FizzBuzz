namespace FizzBuzzService;

public class FizzBuzzService
{
    public static string CheckIfIntegerDivisibleByThreeOrFiveAndReturnResult(int integer)
    {
        var numberIsDivisibleByThree = integer % 3 == 0;
        var numberIsDivisibleByFive = integer % 5 == 0;

        var result = string.Empty;
        if (numberIsDivisibleByThree && numberIsDivisibleByFive)
        {
            result = "FizzBuzz";
        }
        else if (numberIsDivisibleByThree)
        {
            //TODO: add enum or constants.
            result = "Fizz";
        }
        else if (numberIsDivisibleByFive)
        {
            result = "Buzz";
        }

        return result;
    }
}