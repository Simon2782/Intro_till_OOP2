namespace Intro_till_OOP2
{
    internal class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
