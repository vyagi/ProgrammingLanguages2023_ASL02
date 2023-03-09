public static class IntUtilities
{
    public static bool IsOdd(this int value) => value % 2 == 1;

    public static bool IsPrime(this int value)
    {
        for (var i = 2; i < value; i++)
            if (value % i == 0)
                return false;

        return true;
    }
}