namespace CompanyName.Geometry.Shapes.Circle
{
    /// <summary>
    /// Модель реализует радиус окружности.
    /// </summary>
    public struct Circle : ICircle
    {
        /// <summary>
        /// Радиус окружности.
        /// </summary>
        public decimal Radius { get; set; }
        
        /// <summary>
        /// Конструктор инициализирует радиус окружности.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        public Circle(decimal radius) =>  Radius = radius;

    }
}