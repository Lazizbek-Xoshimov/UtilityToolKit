namespace UtilityToolKit.Menus;

public static class MainMenu
{
    public static void BaseMenu()
    {
        Console.WriteLine("Utility Toolkit");
        Console.WriteLine("1. String Helper");
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
            default: Console.WriteLine("You choose a differenet number."); break;
        }
    }
}