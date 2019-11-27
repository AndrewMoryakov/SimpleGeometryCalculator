using CompanyName.Geometry.Shapes.Circle;

namespace CompanyName.Geometry.Shapes.Triangle
{
    /// <summary>
    /// Интерфейс описывает стороны треугольника.
    /// </summary>
    public interface ITriangle : IShape
    {
        /// <summary>
        /// Первая сторона треугольника.
        /// </summary>
        decimal ASide { get; set; }
        /// <summary>
        /// Вторая сторона треугольника.
        /// </summary>
        decimal BSide { get; set; }
        /// <summary>
        /// Третья сторона треугольника.
        /// </summary>
        decimal CSide { get; set; }
        
    }
}