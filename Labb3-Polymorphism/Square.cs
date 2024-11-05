namespace Labb3_Polymorphism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 7;
        }

        public Square(double side)
        {
            if (side < 0)
            {
                side = 7;
            }

            Side = side;
        }

        //Polymorphism används här för att overridea de virtual metoderna som finns i Geometry klassen.
        //Här gjorde jag override av metoderna för att anpassa metoderna så dom funkar för just denna
        //klass på rätt sätt.
        public override double Area()
        {
            return Side * Side;
        }

        public override double Circumference()
        {
            return Side * 4;
        }

        public override string FormType()
        {
            return "Square";
        }
    }
}
