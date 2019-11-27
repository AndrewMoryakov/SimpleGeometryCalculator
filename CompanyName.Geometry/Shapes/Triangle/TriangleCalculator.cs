using System;
using CompanyName.Geometry.Shapes.Circle;

namespace CompanyName.Geometry.Shapes.Triangle
{
    /// <summary>
    /// Класс предоставляет механизм для рассчета параетров треугольника.
    /// </summary>
    /// <typeparam name="TTriangle">Должен быть унаследован от ITriangle.</typeparam>
    public class TriangleCalculator<TTriangle>:IShapeCalculator where TTriangle:ITriangle
    {
        private ITriangle _triangle;
        private const decimal Half = 2;
        private static string _overflowAreaErrorMessage = "Вычиленная площадь треугольника превышает допустимое значения используемого типа.";
        private static string _overflowPErrorMessage = "Произошло переполнение типа.";

        /// <summary>
        /// Возвращает площадь треугольника. Может быть потеряна 
        /// </summary>
        /// <param name="targetTriangle">Объект описывающий треугольник <typeparam name="IShape">Должен быть унаследован от ITriangle</typeparam></param>.
        /// <returns>Возвращает площадь треугольника.</returns>
        public decimal CalculateArea(IShape targetTriangle)
        {
            _triangle = (ITriangle) targetTriangle;

            var p = (double)GetHalfPerimeter();
            var a = (double)_triangle.ASide;
            var b = (double)_triangle.BSide;
            var c = (double)_triangle.CSide;

            decimal area = 0;

            try
            {
                area = (decimal) Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            catch
            {
                throw new ArgumentException(_overflowAreaErrorMessage);
            }

            return area;
        }

        public bool IsRightTriangle(IShape targetTriangle)
        {
                var a = _triangle.ASide;
                var b = _triangle.BSide;
                var c = _triangle.CSide;

                try
                {
                    return (a * a + b * b == c * c)
                           || (a * a + c * c == b * b)
                           || (c * c + b * b == a * a);
                }
                catch (Exception e)
                {
                    throw new ArgumentException(_overflowPErrorMessage);
                }
        }

        private decimal GetHalfPerimeter()
        {
            return (_triangle.ASide + _triangle.BSide + _triangle.CSide) / Half;
        }
    }
}