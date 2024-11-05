namespace Labb3_Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        private double _pi = 3.14;

        public Circle()
        {
            Radius = 5;
        }

        public Circle(double radius)
        {
            if(radius < 0)
            {
                radius = 5;
            }

            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * _pi;
        }

        public override double Circumference()
        {
            return 2 * _pi * Radius;
        }

        public override string FormType()
        {
            return "Circle";
        }
    }
}
