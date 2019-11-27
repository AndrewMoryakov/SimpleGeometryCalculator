using CompanyName.Geometry;
using CompanyName.Geometry.Shapes.Triangle;
using CompanyName.Geometry.Shapes.Circle;
using CompanyName.Geometry.Shapes.Triangle;
using Xunit;

namespace XUnitTestProject1
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(10, 12, 10, 48)]
        [InlineData(0, 0, 0, 0)]
        public void СalculateTriangleAreaByThreeSidesWithCorrectExpectedArea(decimal a, decimal b, decimal c, decimal expectArea)
        {
            var circle = new Triangle(a, b, c);
            var circleCalculator = new TriangleCalculator<Triangle>();
            var mainCalculator = new ShapeCalculator<Triangle>(circleCalculator);

            var actualArea = mainCalculator.CalculateArea(circle);

            Assert.True(actualArea == expectArea);
        }
        
        [Theory]
        [InlineData(10, 12, 10, 41)]
        [InlineData(0, 0, 0, 1)]
        public void СalculateTriangleAreaByThreeSidesWithFakeExpectedArea(decimal a, decimal b, decimal c, decimal expectArea)
        {
            var circle = new Triangle(a, b, c);
            var circleCalculator = new TriangleCalculator<Triangle>();
            var mainCalculator = new ShapeCalculator<Triangle>(circleCalculator);

            var actualArea = mainCalculator.CalculateArea(circle);

            Assert.True(actualArea != expectArea);
        }
    }
}