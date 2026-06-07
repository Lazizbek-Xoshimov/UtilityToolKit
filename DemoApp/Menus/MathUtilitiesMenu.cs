using System.Runtime.InteropServices;
using UtilityToolKit.Helpers;

namespace UtilityToolKit.DemoApp.Menus;

public class MathUtilitiesMenu
{
    public static void BaseMenu()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Math Utilities");
        Console.ResetColor();
        Console.WriteLine("1. Check for even number");
        Console.WriteLine("2. Check for odd number");
        Console.WriteLine("3. Calculate factorial of number");
        Console.WriteLine("4. Calculate the degree of number");
        Console.WriteLine("0. Back");

        Console.Write("Choice: ");
        int option = int.Parse(Console.ReadLine());
        SelectionMenu(option);
    }

    public static void SelectionMenu(int option)
    {
        switch (option)
        {
            case 0: MainMenu.BaseMenu(); break;
            case 1: IsEvenMenu(); break;
            case 2: IsOddMenu(); break;
            case 3: FactorialMenu(); break;
            case 4: PowerMenu(); break;
            default: Console.WriteLine("You choose a different number."); break;
        }
    }

    public static void IsEvenMenu()
    {
        Console.Write("Enter the number to check: ");
        int number = int.Parse(Console.ReadLine());

        if (MathUtilities.IsEven(number))
            Console.WriteLine($"{number} is even.");
        else   
            Console.WriteLine($"{number} is not even, it's odd.");
    }

    public static void IsOddMenu()
    {
        Console.Write("Enter the number to check: ");
        int number = int.Parse(Console.ReadLine());

        if (MathUtilities.IsOdd(number))
            Console.WriteLine($"{number} is odd.");
        else   
            Console.WriteLine($"{number} is not odd, it's even.");
    }

    public static void FactorialMenu()
    {
        Console.Write("Enter the number to calculate factorial for: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"{number}! equals: {MathUtilities.Factorial(number)}");
    }

    public static void PowerMenu()
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the degree: ");
        int degree = int.Parse(Console.ReadLine());

        Console.WriteLine($"{degree}th degree of {number}: {MathUtilities.Power(number, degree)}");
    }
}