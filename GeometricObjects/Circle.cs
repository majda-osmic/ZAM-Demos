namespace GeometricObjects
{

    public class Circle
    {
        protected static int _count = 0;
        public static int Count { get { return _count; } }

        private int _radius;
        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
            }

        }
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }

        public Circle(int radius) : this(radius, 0, 0)
        {
        }

        public Circle(int xCoordinate, int yCoordinate) : this(0, xCoordinate, yCoordinate)
        {

        }

        public Circle(long xCoordinate, long yCoordinate) : this(0, xCoordinate, yCoordinate)
        {

        }

        public Circle(int radius, double xCoordinate, double yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Radius = radius;
            _count++;
        }

        public static double GetArea(Circle circle)
        {
            if (circle == null)
            {
                return 0;
            }

            return Math.Pow(circle.Radius, 2) * Math.PI;
        }

        public double GetArea() => GetArea(this);



        public double GetCircumference() => 2 * Radius * Math.PI;

        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        public void Move(double dx, double dy, int dRadius)
        {
            Move(dx, dy);
            Radius += dRadius;
        }



        public int Bigger(Circle circle2)
        {
            return Bigger(this, circle2);
        }

        public static int Bigger(Circle circle1, Circle circle2)
        {
            if (circle1 == null && circle2 == null) return 0;
            if (circle1 == null) return -1;
            if (circle2 == null) return 1;

            if (circle1.Radius > circle2.Radius) return 1;
            if (circle1.Radius < circle2.Radius) return -1;
            return 0;
        }
    }
}