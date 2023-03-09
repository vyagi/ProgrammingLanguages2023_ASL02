//Do this :

public class Pair<T1, T2>
{
    public T1 A;

    public T2 B;

    public Pair(T1 a, T2 b)
    {
        A = a;
        B = b;
    }
}

//It's a crap, don't do it. Ever.
// public class PairObject
// {
//     public object A;
//
//     public object B;
//
//     public PairObject(object a, object b)
//     {
//         A = a;
//         B = b;
//     }
// }

//public class PairInt
//{
//    public int A;

//    public int B;

//    public PairInt(int a, int b)
//    {
//        A = a;
//        B = b;
//    }
//}

//public class PairString
//{
//    public string A;

//    public string B;

//    public PairString(string a, string b)
//    {
//        A = a;
//        B = b;
//    }
//}
//public class PairDateTime
//{
//    public DateTime A;

//    public DateTime B;

//    public PairDateTime(DateTime a, DateTime b)
//    {
//        A = a;
//        B = b;
//    }
//}