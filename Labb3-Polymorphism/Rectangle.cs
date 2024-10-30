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
    }
}
