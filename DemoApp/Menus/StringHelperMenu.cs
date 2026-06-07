using UtilityToolKit.Helpers;

namespace UtilityToolKit.DemoApp.Menus;

public class StringHelperMenu
{
    public static void BaseMenu()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("String Helper menu");
        Console.ResetColor();
        Console.WriteLine("1. Checking a string for palindrome");
        Console.WriteLine("2. Reverse text");
        Console.WriteLine("3. Count of words");
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
            case 1: IsPalindromeMenu(); break;
            case 2: ReverseTextMenu(); break;
            case 3: CountOfWordsMenu(); break;
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

    public static void ReverseTextMenu()
    {
        Console.Write("Enter string to be reversed: ");
        string text = Console.ReadLine();

        Console.WriteLine($"Reversed text: {StringHelper.ReverseText(text)}");
    }

    public static void CountOfWordsMenu()
    {
        Console.Write("Enter string to count of words in: ");
        string text = Console.ReadLine();

        Console.WriteLine($"Number of words: {StringHelper.CountOfWords(text)}");
    }
}