using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.Geometry.Shapes;
using CompanyName.Geometry.Shapes.Circle;

namespace CompanyName.Geometry
{
    public class ShapeCalculator<TShape> where TShape:IShape
    {
        private IShapeCalculator _shapeCalculator;
        public ShapeCalculator(IShapeCalculator calculator)
        {
            _shapeCalculator = calculator;
        }

        public decimal CalculateArea(TShape someShape)
        {
            return _shapeCalculator.CalculateArea(someShape);
        }
    }
}
