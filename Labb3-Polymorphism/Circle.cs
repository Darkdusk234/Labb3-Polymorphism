namespace Labb3_Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        private double _pi = 3.14;

        public override double Area()
        {
            return Radius * Radius * _pi;
        }

        public Circle()
        {
            Radius = 5;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
