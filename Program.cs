

}
class LineSegment
{
    private (double X, double Y) pointStart;
    private (double X, double Y) pointEnd;

    public LineSegment((double X, double Y) pointStart, (double X, double Y) pointEnd)
    {
        this.pointStart = pointStart;
        this.pointEnd = pointEnd;
    }

    public double DistanceTriangle()
    {
        double a = pointEnd.X - pointStart.X;
        double c = pointStart.Y - pointEnd.Y;
        double b = Math.Pow(a, 2) + Math.Pow(c, 2);
        return Math.Sqrt(b);
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter X coordinate of starting point: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of starting point: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter X coordinate of ending point: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of ending point: ");
        double y2 = double.Parse(Console.ReadLine());
        
        LineSegment distance = new LineSegment((x1, y1), (x2, y2));
        Console.WriteLine(Math.Round(distance.DistanceTriangle(), 3));
    }
}