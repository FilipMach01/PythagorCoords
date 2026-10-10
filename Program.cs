

record Point(double X, double Y);
class LineSegment
{
    private readonly Point _start;
    private readonly Point _end;

    public LineSegment(Point start, Point end)
    {
        _start = start;
        _end = end;
    }

    public double Distance()
    {
        double a = _end.X - _start.X;
        double c = _start.Y - _end.Y;
        double b = Math.Pow(a, 2) + Math.Pow(c, 2);
        return Math.Sqrt(b);
    }

    public double[] Mid()
    {
        double xMid = (_end.X - _start.X) / 2;
        double yMid = (_end.Y - _start.Y) / 2;
        return [xMid, yMid];
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
        
        Point start = new Point(x1, y1);
        Point end = new Point(x2, y2);
        
        LineSegment linesegment = new LineSegment(start, end);
        Console.WriteLine(Math.Round(linesegment.Distance(), 3));

        double[] mid = linesegment.Mid();
        Console.WriteLine($"Mid: [{mid[0]}, {mid[1]}]");
    }
}