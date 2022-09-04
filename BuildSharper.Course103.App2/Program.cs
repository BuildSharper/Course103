Console.WriteLine("************************************");
Console.WriteLine("Let's sing the 12 Days of Christmas!");
Console.WriteLine("************************************");

var lines = new string[]
{
    "a partridge in a pear tree",
    "2 turtledoves",
    "3 french hens",
    "4 calling birds",
    "5 golden rings",
    "6 geese a laying",
    "7 swans a swimming",
    "8 maids a milking",
    "9 ladies dancing",
    "10 lords a leaping",
    "11 pipers piping",
    "12 drummers drumming"
};

for (int i = 0; i < 12; i++)
{
    Console.WriteLine($"On the {GetDay(i + 1)} day of Christmas, my true love gave to me...");

    for (int j = i; j >= 0; j--)
    {
        Console.WriteLine(lines[j]);
    }

    Console.ReadLine();
}

Console.ReadLine();

static string GetDay(int day)
{
    switch (day)
    {
        case 1:
            return "first";
        case 2:
            return "second";
        case 3:
            return "third";
        case 4:
            return "forth";
        case 5:
            return "fifth";
        case 6:
            return "sixth";
        case 7:
            return "seventh";
        case 8:
            return "eighth";
        case 9:
            return "ninth";
        case 10:
            return "tenth";
        case 11:
            return "eleventh";
        case 12:
            return "twelfth";
        default:
            return string.Empty;
    }
}