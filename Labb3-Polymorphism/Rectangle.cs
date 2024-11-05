namespace Labb3_Polymorphism
{
    internal class Rectangle : Geometry 
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 5;
            Height = 3;
        }

        public Rectangle(double width, double height)
        {
            if(width < 0)
            {
                width = 5;
            }

            if(height < 0)
            {
                height = 0;
            }

            Width = width;
            Height = height;
        }

        //Polymorphism används här för att overridea de virtual metoderna som finns i Geometry klassen.
        //Här gjorde jag override av metoderna för att anpassa metoderna så dom funkar för just denna
        //klass på rätt sätt.
        public override double Area()
        {
            return Width * Height;
        }

        public override double Circumference()
        {
            return (Width * 2) + (Height * 2);
        }

        public override string FormType()
        {
            return "Rectangle";
        }
    }
}
