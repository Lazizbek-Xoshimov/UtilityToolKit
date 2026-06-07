namespace UtilityToolKit.DemoApp.Menus;

public static class MainMenu
{
    public static void BaseMenu()
    {
        Console.WriteLine("Utility Toolkit");
        Console.WriteLine("1. String Helper");
        Console.WriteLine("2. Math Utilities");
        Console.WriteLine("3. Pagination");
        Console.WriteLine("0. Exit");

        Console.Write("Choice: ");
        int option = int.Parse(Console.ReadLine());
        SelectionMenu(option);
    }

    public static void SelectionMenu(int option)
    {
        switch (option)
        {
            case 1: StringHelperMenu.BaseMenu(); break;
            case 2: MathUtilitiesMenu.BaseMenu(); break;
            case 3: PaginationExtensionMenu.BaseMenu(); break;
            default: Console.WriteLine("You choose a differenet number."); break;
        }
    }
}