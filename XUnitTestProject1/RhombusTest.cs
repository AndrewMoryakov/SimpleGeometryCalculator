using System;
using CompanyName.Geometry;
using Xunit;
using XUnitTestProject1.Shapes;

namespace XUnitTestProject1
{
    public class RhombusTest
    {
        [Theory]
        [InlineData(10, 11, 110)]
        [InlineData(0, 0, 0)]
        public void СalculateRhombusAreaByThreeSidesWithCorrectExpectedArea(decimal a, decimal h, decimal expectArea)
        {
            var rhombus = new Rhombus(a, h);
            var rhombusCalculator = new RhombusCalculator<Rhombus>();
            var mainCalculator = new ShapeCalculator<Rhombus>(rhombusCalculator);

            var actualArea = mainCalculator.CalculateArea(rhombus);

            Assert.True(actualArea == expectArea);
        }
        
        [Theory]
        [InlineData(10, 12, 121)]
        [InlineData(0, 0, 1)]
        public void СalculateRhombusAreaByThreeSidesWithFakeExpectedArea(decimal a, decimal h, decimal expectArea)
        {
            var rhombus = new Rhombus(a, h);
            var rhombusCalculator = new RhombusCalculator<Rhombus>();
            var mainCalculator = new ShapeCalculator<Rhombus>(rhombusCalculator);

            var actualArea = mainCalculator.CalculateArea(rhombus);

            Assert.True(actualArea != expectArea);
        }
        
        [Fact]
        public void TypeOverflowExpectException()
        {
            var a = Decimal.MaxValue;
            var h = 2;
            var rhombus = new Rhombus(a, h);
            var rhombusCalculator = new RhombusCalculator<Rhombus>();
            var mainCalculator = new ShapeCalculator<Rhombus>(rhombusCalculator);

            Assert.Throws<ArgumentException>(() => mainCalculator.CalculateArea(rhombus));
        }
    }
}