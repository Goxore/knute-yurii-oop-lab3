public class Exercise1
{
    public static void Run()
    {
        int s1 = Convert.ToInt32(Console.ReadLine());
        int s2 = Convert.ToInt32(Console.ReadLine());

        Rectangle rect = new Rectangle(s1, s2);
        System.Console.WriteLine(rect.Area);
        System.Console.WriteLine(rect.Perimeter);
    }
}

class Rectangle
{
    double side1, side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    double AreaCalculator()
    {
        return side1 * side2;
    }

    double PerimeterCalculator()
    {
        return (side1 + side2) * 2;
    }

    public double Area { get { return AreaCalculator(); } }
    public double Perimeter { get { return PerimeterCalculator(); } }

}
