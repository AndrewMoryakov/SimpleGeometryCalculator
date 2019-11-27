using CompanyName.Geometry.Shapes;
using CompanyName.Geometry.Shapes.Circle;

namespace XUnitTestProject1.Shapes
{
    /// <summary>
    /// Ромб наследуется напрямую от IShape, так как это пользовательская реализация и известно, что поведение фигуры ромб
    /// будет только таким. Например не будет инициализации значений из файла.
    /// </summary>
    internal class Rhombus : IShape
    {
        internal Rhombus(decimal a, decimal h)
        {
            A = a;
            H = h;
        }
        
        internal decimal A { get; set; }
        internal decimal H { get; set; }
    }
}