namespace Labb3_Polymorphism
{
    internal class Geometry
    {
        //Polymorphism används i denna klass genom att metoderna är virtual vilket gör att man kan
        //overridea dom i sub klasser och därför anpassa dom för den klassen.
        public virtual double Area()
        {
            return 0;
        }

        public virtual double Circumference()
        {
            return 0;
        }

        public virtual string FormType()
        {
            return "";
        }
    }
}
