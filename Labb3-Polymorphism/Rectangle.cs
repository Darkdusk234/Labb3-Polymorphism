namespace Labb3_Polymorphism
{
    internal class Rectangle : Geometry 
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public Rectangle()
        {
            Width = 5;
            Height = 3;
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
