using UtilityToolKit.Extensions;

namespace UtilityToolKit.DemoApp.Menus;

public class PaginationExtensionMenu
{
    static List<int> numbers = new List<int>();

    public static void BaseMenu()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Pagination");
        Console.ResetColor();
        Console.WriteLine("1. Get the number on page");
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
            case 1: PaginateMenu(); break;
            default: Console.WriteLine("You choose a differenet number."); break;
        }
    }

    public static void PaginateMenu()
    {
        Random random = new Random();

        Console.Write("Enter the size of numbers: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            numbers.Add(random.Next(size));
        }

        ConsoleKeyInfo button;
        int page = 1;

        do
        {
            if (page < 1 || page * 10 > size)
                break;

            Console.Write($"\n<- quit ->");
            button = Console.ReadKey();

            if (button.Key.Equals(ConsoleKey.LeftArrow))
            {
                Console.Clear();
                foreach(var number in numbers.Paginate(page --, 10))
                {
                    Console.Write($"{number} ");
                }
            }
            else if (button.Key.Equals(ConsoleKey.RightArrow))
            {
                Console.Clear();
                foreach(var number in numbers.Paginate(page ++, 10))
                {
                    Console.Write($"{number} ");
                }
            }
        } while (!button.Key.Equals(ConsoleKey.Q));
    }
}