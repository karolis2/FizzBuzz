namespace FizzBuzzService;

public class FizzBuzzService
{
    public static string CheckIfIntegerDivisibleByThreeOrFiveAndReturnResult(int integer)
    {
        var numberIsDivisibleByThree = integer % 3 == 0;
        var result = string.Empty;

        if (numberIsDivisibleByThree)
        {
            //TODO: add enum or constants.
            result = "Fizz";
        }

        return result;
    }
}