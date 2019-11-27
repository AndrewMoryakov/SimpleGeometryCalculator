using System;
using CompanyName.Geometry.Shapes;
using CompanyName.Geometry.Shapes.Circle;

namespace XUnitTestProject1.Shapes
{
    /// <summary>
    /// Пользовательская реализация калькулятора ромба. Известно, что ромбов будет 1 тип, поэтому данному классу известно
    /// именно о конкретном классе <typeparam name="Rhombus">ромб</typeparam>
    /// </summary>
    /// <typeparam name="TRhombus">Класс описывающий ромб</typeparam>
    internal class RhombusCalculator<TRhombus> : IShapeCalculator where TRhombus : Rhombus
    {
        private const string _overflowErrorMessage = "Произошло переполнение типа при вычислении площади.";

        public decimal CalculateArea(IShape targetRhombus)
        {
            var rhombus = (Rhombus) targetRhombus;
            decimal area = 0;

            try
            {
                area = rhombus.A * rhombus.H;
            }
            catch (Exception e)
            {
                throw new ArgumentException(_overflowErrorMessage);
            }

            return area;
        }
    }
}