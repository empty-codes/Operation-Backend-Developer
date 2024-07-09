// Boss Battle 1 - The Point

Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"({point1.X}, {point1.Y})");
Console.WriteLine($"({point2.X}, {point2.Y})");

point2.Y = 5;
Console.WriteLine($"({point2.X}, {point2.Y})");

Console.ReadKey();

public class Point {
    public int X {get; set;}
    public int Y { get; set; }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}