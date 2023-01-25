 
Console.Write("ВВедите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, y1, x2, y2);
double endResult = Math.Round(result, 2, MidpointRounding.ToZero);
Console.Write($"A ({x1}, {y1}); B ({x2}, {x2}) -> ");
Console.WriteLine($"{endResult}");

double Distance(int xA,int yA,int xB,int yB)
{
    int cat1 = xA - xB;
    int cat2 = yA - yB;
    double distance = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return distance;
}