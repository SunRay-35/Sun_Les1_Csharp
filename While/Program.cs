// Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");
//while (count)
//{
//    ....
//    count = count + 1;
//}
int xa = 45, ya = 1,
    xb = 1, yb = 40,
    xc = 80, yc = 35;

Console.Clear();
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = yb, count = 0, what = new Random().Next(0,3);

while (count < 1000000)
{
    if (what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if (what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if (what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    what = new Random().Next(0,3);
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
Console.SetCursorPosition(1, 41);