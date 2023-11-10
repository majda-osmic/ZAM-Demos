

using Interfaces;

namespace GeometricObjects
{
    public class GraphicCircle : Circle, IDrawable
    {
        public GraphicCircle(int radius) : this(0, 0, 0)
        {
        }

        public GraphicCircle(int xCoordinate, int yCoordinate) : this(0, xCoordinate, yCoordinate)
        {
        }

        public GraphicCircle(int radius, double xCoordinate, double yCoordinate) : base(radius, xCoordinate, yCoordinate)
        {
            _count++;
        }

        public void Draw()
        {
            double area = GetArea();
            Console.WriteLine("The circle is now being drawn");
        }
    }
}