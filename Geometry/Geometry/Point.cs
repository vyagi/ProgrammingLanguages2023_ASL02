namespace Geometry;

public class Point : IMoveAble
{
    private double _x;
    private double _y;

    public Point() : this(0, 0) { }
    
    public Point(double x) : this(x,x) { } 
    
    public Point(double x, double y) => (_x, _y) = (x, y);

    public double X => _x;

    public double Y => _y;

    public double Distance => Math.Sqrt(_x * _x + _y * _y);

    public void Move(double x, double y) => (_x, _y) = (_x + x, _y + y);
}