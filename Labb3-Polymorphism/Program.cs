namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle(7.3);
            Geometry rectangle = new Rectangle(8.5, 5.7);
            Geometry square = new Square(9.2);
            Geometry triangle = new Triangel(9.4, 7.1);

        }
    }
}
