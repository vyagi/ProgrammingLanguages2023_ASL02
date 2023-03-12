using FluentAssertions;

namespace Geometry.Tests;

public class PointTests
{
    [Fact]
    public void Can_create_a_point()
    {
        var point = new Point();

        point.X.Should().Be(0);
        point.Y.Should().Be(0);
    }

    [Fact]
    public void Can_create_a_point_with_one_parameter()
    {
        var point = new Point(5.5);

        point.X.Should().Be(5.5);
        point.Y.Should().Be(5.5);
    }

    [Fact]
    public void Can_create_a_point_with_two_parameters()
    {
        var point = new Point(5.5 ,-4.5);

        point.X.Should().Be(5.5);
        point.Y.Should().Be(-4.5);
    }

    [Fact]
    public void Point_is_moveable()
    {
        var point = new Point();

        point.Should().BeAssignableTo<IMoveAble>();
    }

    [Fact]
    public void Move_should_change_coordinates()
    {
        var point = new Point(2,3);

        point.Move(-1, 2);

        point.X.Should().Be(1);
        point.Y.Should().Be(5);
    }

    [Fact]
    public void Distance_is_correct()
    {
        var point = new Point(4, 3);

        point.Distance.Should().Be(5);
    }
}