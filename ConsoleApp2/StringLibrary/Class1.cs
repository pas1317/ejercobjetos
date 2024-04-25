namespace UtilityLibraries;
public static class StringLibrary
{
    public static bool StartsWhithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;
        char ch = str[ 0];
            return char.IsUpper(ch);
    }
}



