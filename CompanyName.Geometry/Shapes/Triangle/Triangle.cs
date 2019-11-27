namespace CompanyName.Geometry.Shapes.Triangle
{
    /// <summary>
    /// Реализует описание треугольника.
    /// </summary>
    public struct Triangle:ITriangle
    {
        /// <summary>
        /// Инициализирует треугольник
        /// </summary>
        /// <param name="aSide">Первая сторона</param>
        /// <param name="bSide">Вторая сторона</param>
        /// <param name="cSide">Третья сторона</param>
        public Triangle(decimal aSide, decimal bSide, decimal cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }
        
        public decimal ASide { get; set; }
        public decimal BSide { get; set; }
        public decimal CSide { get; set; }
    }
}