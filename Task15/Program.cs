
Console.WriteLine("--------------------ПРИНИМАЕТ ЦИФРУ, ПРОВЕРЯЕТ ЯВЛЯЕТСЯ ДЕНЬ НЕДЕЛИ ВЫХОДНЫМ--------------------");
Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (ControlEnter(number) == -1)
    Console.WriteLine("Введено не верное значение!");
else
{
    if(ControlEnter(number) == 1) Console.WriteLine("Нет");
    if(ControlEnter(number) == 2) Console.WriteLine("Нет");
    if(ControlEnter(number) == 3) Console.WriteLine("Нет");
    if(ControlEnter(number) == 4) Console.WriteLine("Нет");
    if(ControlEnter(number) == 5) Console.WriteLine("Нет");
    if(ControlEnter(number) == 6) Console.WriteLine("Да");
    if(ControlEnter(number) == 7) Console.WriteLine("Да");    
}

int ControlEnter(int num)
{
    if (1 <= num && num <= 7)
    {
        return num;
    }
    else
        return -1;
}