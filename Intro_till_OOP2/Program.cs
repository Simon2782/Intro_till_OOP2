namespace Intro_till_OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            double area1 = circle1.GetArea();
            Console.WriteLine($"Arean för en cirkel med radien 5 är: {area1}");

            Circle circle2 = new Circle(6);
            double area2 = circle2.GetArea();
            Console.WriteLine($"Arean för en cirkel med radien 6 är: {area2}");
        }
    }
}
