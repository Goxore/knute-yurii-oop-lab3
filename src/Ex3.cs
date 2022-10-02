public class Exercise3
{
    public static void Run()
    {
        Point p1 = new Point(0,0,"A");
        Point p2 = new Point(3,3,"B");
        Point p3 = new Point(5,-4,"C");
        Point p4 = new Point(-7,-5,"D");

        Figure figure = new Figure(p1, p2, p3, p4);
        figure.PerimeterCalculator();
    }
}

public class Figure
{
    List<Point> points = new List<Point>();

    public static double LengthSide(Point A, Point B){
        return Math.Sqrt(Math.Pow(A.x-B.x,2)+Math.Pow(A.y-B.y,2));
    }

    public void PerimeterCalculator(){
        double perimeter = 0;

        for (int i = 1; i < points.Count; i++)
        {
            perimeter += LengthSide(points[i], points[i-1]);
        }

        System.Console.WriteLine($"Perimeter: {perimeter}");
    }

    public Figure(Point point1, Point point2, Point point3)
    {
        points.Add(point1);
        points.Add(point2);
        points.Add(point3);
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points.Add(point1);
        points.Add(point2);
        points.Add(point3);
        points.Add(point4);
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points.Add(point1);
        points.Add(point2);
        points.Add(point3);
        points.Add(point4);
        points.Add(point5);
    }
}

public class Point
{
    public int x = 0;
    public int y = 0;
    public string str = "";

    public Point(int x, int y, string str)
    {
        this.x = x;
        this.y = y;
        this.str = str;
    }
}
