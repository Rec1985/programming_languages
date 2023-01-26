// Task21:
//     Напишите программу, которая принимает на вход координаты двух точек 
//     и находит расстояние между ними в 3D пространстве.
//     A (3,6,8); B (2,1,-7), -> 15.84
//     A (7,-5, 0); B (1,-1,9) -> 11.53
 
Console.Clear();
Console.Write("ВВедите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("ВВедите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, y1, z1, x2, y2, z2);
double endResult = Math.Round(result, 2, MidpointRounding.ToZero); // Округляем до 2х знаков
Console.Write($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> ");
Console.WriteLine($"{endResult}");

double Distance(int xA,int yA,int zA,int xB,int yB,int zB )
{
    int catX = xA - xB;
    int catY = yA - yB;
    int catZ = zA - zB;
    double distance = Math.Sqrt(catX * catX + catY * catY + catZ * catZ);
    return distance;
}