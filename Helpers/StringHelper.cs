namespace UtilityToolKit.Helpers;

public static class StringHelper
{
    public static bool IsPalindrome(string text) => 
        new string(text.Reverse().ToArray()).Equals(text) ? true : false;

    public static string ReverseText(string text) =>
        new string(text.Reverse().ToArray());

    public static int CountOfWords(string text) =>
        text.Split(' ').Count();
}