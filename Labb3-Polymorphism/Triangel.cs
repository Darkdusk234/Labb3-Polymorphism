namespace Labb3_Polymorphism
{
    internal class Triangel : Geometry
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return (Width * Height) / 2;
        }

        public Triangel()
        {
            Width = 2.3;
            Height = 3.1;
        }

        public Triangel(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
