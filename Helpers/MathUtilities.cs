namespace UtilityToolKit.Helpers;

public static class MathUtilities
{
    public static bool IsEven(int number) =>
        number % 2 == 0 ? true : false;

    public static bool IsOdd(int number) =>
        number % 2 == 1 ? true : false;

    public static int Factorial(int number) =>
        Enumerable.Range(1, number).Aggregate((firstNumber, secondNumber) => firstNumber * secondNumber);

    public static int Power(int number, int degree) =>
        Enumerable.Repeat(number, degree).Aggregate((first, second) => first * second);
}