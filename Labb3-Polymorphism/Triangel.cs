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
    }
}
