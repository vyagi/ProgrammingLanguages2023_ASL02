using System.Collections;

public class Names : IEnumerable<string>
{
    public string FirstName;
    public string SecondName;
    public string LastName;
    public IEnumerator<string> GetEnumerator()
    {
        Console.WriteLine("GetEnumerator called for the first time");
        yield return FirstName;
        Console.WriteLine("GetEnumerator called for the second time");
        yield return SecondName;
        Console.WriteLine("GetEnumerator called for the third time");
        yield return LastName;
        Console.WriteLine("GetEnumerator called for the last time");
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}