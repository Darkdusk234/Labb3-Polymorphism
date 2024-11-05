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

        //Polymorphism används här för att overridea de virtual metoderna som finns i Geometry klassen.
        //Här gjorde jag override av metoderna för att anpassa metoderna så dom funkar för just denna
        //klass på rätt sätt.
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
