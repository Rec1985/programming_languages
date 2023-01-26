
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeNumber(number);

void CubeNumber(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine($"{count,5} -> {count * count * count,5}");        
        count++;
    }
}