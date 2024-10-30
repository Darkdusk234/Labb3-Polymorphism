namespace Labb3_Polymorphism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public override double Area()
        {
            return Side * Side;
        }

        public Square()
        {
            Side = 7;
        }
    }
}
