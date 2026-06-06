using UtilityToolKit.Helpers;

namespace UtilityToolKit.Menus;

public class StringHelperMenu
{
    public static void BaseMenu()
    {
        Console.WriteLine("String Helper menu");
        Console.WriteLine("1. Checking a string for palindrome");
        Console.WriteLine("0. Back");

        Console.Write("Choice: ");
        int option = int.Parse(Console.ReadLine());
        SelectionMenu(option);
    }

    public static void SelectionMenu(int option)
    {
        switch (option)
        {
            case 1: IsPalindromeMenu(); break;
            default: Console.WriteLine("You choose a different number."); break;
        }
    }

    public static void IsPalindromeMenu()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        if (StringHelper.IsPalindrome(text))
            Console.WriteLine($"{text} is palindrome.");
        else
            Console.WriteLine($"{text} is not palindrome.");
    }
}