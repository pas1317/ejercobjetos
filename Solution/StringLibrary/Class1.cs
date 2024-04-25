namespace UtilityLibraries;


public static class StringLibrary
{
    public static bool StartsWithUpper(this string ? str)
    {
        if (string.IsNullOrEmpty(str))
            return false;
        char ch = str[0];
        return char.IsUpper(ch);
    }
}
