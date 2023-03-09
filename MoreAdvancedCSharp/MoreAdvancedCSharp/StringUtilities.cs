public static class StringUtilities
{
    //adding "this" converted it to an extension method
    public static string Capitalize(this string input) => 
        input[0].ToString().ToUpper() + input.Substring(1);
}

//not possible, because string is sealed
// public class BetterString : string
// {
//
// }