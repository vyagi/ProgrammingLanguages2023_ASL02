using FluentAssertions;

namespace Geometry.Tests
{
    public class SegmentTests
    {
        [Fact]
        public void Can_create_a_segment()
        {
            var segment = new Segment(new Point(1,2), new Point(3,4));

            segment.Start.X.Should().Be(1);
            segment.Start.Y.Should().Be(2);

            segment.End.X.Should().Be(3);
            segment.End.Y.Should().Be(4);
        }
    }
}
