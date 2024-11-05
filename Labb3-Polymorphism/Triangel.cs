namespace Labb3_Polymorphism
{
    internal class Triangel : Geometry
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Triangel()
        {
            Width = 2.3;
            Height = 3.1;
        }

        public Triangel(double width, double height)
        {
            if (width < 0)
            {
                width = 5;
            }

            if (height < 0)
            {
                height = 0;
            }

            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return (Width * Height) / 2;
        }

        public override double Circumference()
        {
            double hyp = Math.Sqrt((Width * Width + Height * Height));
            return Width + Height + hyp;
        }

        public override string FormType()
        {
            return "Triangle";
        }
    }
}
