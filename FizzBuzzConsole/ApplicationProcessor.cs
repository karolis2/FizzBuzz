using static FizzBuzzService.FizzBuzzService;

namespace FizzBuzzConsole;

internal static class ApplicationProcessor
{
    internal static void ExecuteRangeOfIntegers(int range)
    {
        var integersRange = Enumerable.Range(1, range).ToList();

        foreach (var integer in integersRange)
        {
            var result = CheckIfIntegerDivisibleByThreeOrFiveAndReturnResult(integer);
            Console.WriteLine(result);
        }
    }
}