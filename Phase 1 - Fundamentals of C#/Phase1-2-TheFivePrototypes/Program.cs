// Boss Battle 1 - The Point

Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"({point1.X}, {point1.Y})");
Console.WriteLine($"({point2.X}, {point2.Y})");

// Boss Battle 2 - The Color
Color color1 = new Color(245, 67, 50);
Color color2 = Color.Purple;

Console.WriteLine($"Color 1: ({color1.RedChannel}, {color1.GreenChannel}, {color1.BlueChannel})");
Console.WriteLine($"Color 2: ({color2.RedChannel}, {color2.GreenChannel}, {color2.BlueChannel})");

// Boss Battle 3 - The Card
void CreateCards()
{
    foreach(CardColor color in Enum.GetValues(typeof(CardColor)))
    {
        foreach(CardRank rank in Enum.GetValues(typeof(CardRank)))
        {
            Card card = new Card(color, rank);
            Console.WriteLine($"The {color} {rank}");
        }
    }
}

CreateCards();

Console.ReadKey();

// Boss Battle 1 - The Point
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

// Boss Battle 2 - The Color
public class Color
{
    public int RedChannel { get; set; }
    public int GreenChannel { get; set; }
    public int BlueChannel { get; set; }

    public Color()
    {
        RedChannel = 0;
        GreenChannel = 0;
        BlueChannel = 0;
    }

    public Color(int red, int green, int blue)
    {
        RedChannel = red;
        GreenChannel = green;
        BlueChannel = blue;
    }

    public static Color White
    {
        get { return new Color { RedChannel = 255, GreenChannel = 255, BlueChannel = 255 }; }
    }

    public static Color Black
    {
        get { return new Color { RedChannel = 0, GreenChannel = 0, BlueChannel = 0 }; }
    }

    public static Color Red
    {
        get { return new Color { RedChannel = 255, GreenChannel = 0, BlueChannel = 0 }; }
    }

    public static Color Orange
    {
        get { return new Color { RedChannel = 255, GreenChannel = 165, BlueChannel = 0 }; }
    }

    public static Color Yellow
    {
        get { return new Color { RedChannel = 255, GreenChannel = 255, BlueChannel = 0 }; }
    }

    public static Color Green
    {
        get { return new Color { RedChannel = 0, GreenChannel = 128, BlueChannel = 0 }; }
    }

    public static Color Blue
    {
        get { return new Color { RedChannel = 0, GreenChannel = 0, BlueChannel = 255 }; }
    }

    public static Color Purple
    {
        get { return new Color { RedChannel = 128, GreenChannel = 0, BlueChannel = 128 }; }
    }

}

// Boss Battle 3 - The Card
class Card
{
    public CardColor Color { get; }
    public CardRank Rank { get; }

    public Card(CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
    }

    public void GetCardType()
    {
        if (Rank == CardRank.Dollar || Rank == CardRank.Percent || Rank == CardRank.Caret || Rank == CardRank.Ampersand)
            Console.WriteLine($"This card is a symbol card ranked {Rank}");
        else Console.WriteLine($"This card is a number card ranked {Rank}");
    }
}


// Boss Battle 3 - The Card
enum CardColor { Red, Green, Blue, Yellow}
enum CardRank { One = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand }