using System;

namespace CompanyName.Geometry.Shapes.Circle
{
    /// <summary>
    /// Класс реализует методы для вычисления метрик окружности.
    /// </summary>
    /// <typeparam name="TShape">TShape должен быть унаследован от ICircle</typeparam>
    public class CircleCalculator<TShape>:IShapeCalculator where TShape:ICircle
    {
        private static string _overflowErrorMessage = "Вычиленная площадь окружности превышает допустимое значения используемого типа.";

        /// <summary>
        /// Вычисляет площадь окружности по радиусу, используя число ПИ со значенеим 3.14159265358979
        /// </summary>
        /// <param name="targetCircle">Объект описывающий окружность. Реализует интерфейс <typeparam name="IShape">ICircle</typeparam>.</param>
        /// <returns>Значение площади окружности.</returns>
        public decimal CalculateArea(IShape targetCircle)
        {
            var circle = (TShape) targetCircle;

            decimal area = 0;

            try
            {
                area = (decimal) (Math.PI * (double) circle.Radius);
            }
            catch (Exception e)
            {
                throw new ArgumentException(_overflowErrorMessage);
            }

            return area;
        }
    }
}