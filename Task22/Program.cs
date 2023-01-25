
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
SquareTable(number);

void SquareTable(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine($"{count} -> {count * count}");        
        count++;
    }
}

