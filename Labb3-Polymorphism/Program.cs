namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här visar jag Polymorphism genom att jag skapar en lista av
            //typen Geometry, och lägger in några olika former.
            //De olika formerna är alla lagrade som Geometry vilket gör att dom går att lägga in i listan
            //men de är egentligen av specifika sub klasser från Geometry t.ex. Circle.
            //Detta gör att man kommer åt de sub klassernas override av metoderna i Geometry klassen.
            List<Geometry> forms = new List<Geometry>();
            Geometry circle = new Circle(7.3);
            forms.Add(circle);
            Geometry rectangle = new Rectangle(8.5, 5.7);
            forms.Add(rectangle);
            Geometry square = new Square(9.2);
            forms.Add(square);
            Geometry triangle = new Triangel(9.4, 7.1);
            forms.Add(triangle);

            foreach (Geometry form in forms)
            {
                Console.WriteLine($"Area of {form.FormType()}: {Math.Round(form.Area(), 2)}");
                Console.WriteLine($"Circumference of {form.FormType()}: {Math.Round(form.Circumference(), 2)}");
                Console.WriteLine();
            }
        }
    }
}
