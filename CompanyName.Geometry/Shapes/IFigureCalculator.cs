namespace CompanyName.Geometry.Shapes.Circle
{
    /// <summary>
    /// Описывает базовые методы для калькуляторов фигур.
    /// </summary>
    public interface IShapeCalculator
    {
        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <param name="targetShape">Фигура, у оторой нужно вычислить площадь.</param>
        /// <returns>Площадь фигуры.</returns>
        decimal CalculateArea(IShape targetShape);
    }
}