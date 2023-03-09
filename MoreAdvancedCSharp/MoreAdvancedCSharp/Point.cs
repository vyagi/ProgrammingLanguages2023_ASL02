public struct Point //: AbstractConceptOfGeometry //will not work for structs
{
    public int X;
    public int Y;

    public Point() //this would not compile for struct back before C# 10
    {

    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}