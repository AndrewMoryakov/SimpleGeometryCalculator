namespace CompanyName.Geometry.Shapes.Circle
{
    /// <summary>
    /// Описывает окружность. В данном интерфейсе реализован радиус.
    /// </summary>
    public interface ICircle : IShape
    {
        /// <summary>
        /// Радиус окружности.
        /// </summary>
        decimal Radius { get; set; }
    }
}