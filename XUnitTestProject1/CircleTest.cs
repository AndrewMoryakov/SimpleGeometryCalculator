using CompanyName.Geometry;
using System;
using CompanyName.Geometry.Shapes.Circle;
using Moq;
using Xunit;

namespace XUnitTestProject1
{
    public class CircleTest
    {
        [Theory]
        [InlineData(10, 31.415926535897931)]
        public void CalculateCircleAreaByRadius(decimal radius, decimal expectArea)
        {
            var circle = new Circle(radius);
            var circleCalculator = new CircleCalculator<Circle>();
            var mainCalculator = new ShapeCalculator<Circle>(circleCalculator);

            var actualArea = mainCalculator.CalculateArea(circle);

            Assert.True(actualArea == expectArea);
        }
    }
}
