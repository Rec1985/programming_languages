Console.WriteLine("--------------------ПРИНИМАЕТ ЧИСЛО, ВЫВОДИТ ТРЕТЬЮ ЦИФРУ ЧИСЛА?--------------------");

Console.Write("Введите значение более 100 или менее -100 включительно: ");
int inNumber = Convert.ToInt32(Console.ReadLine()); // Вводимое число

if (CheckNumber(inNumber) == -1) // Если пользователь ввел не правильное значение
{
    Console.WriteLine("Третей цифры нет");
}
else
{
    int var = inNumber;
    while (var < -1000 || var > 1000)
    {
        var /= 10;
    }
    int result = var % 10;
    if(result < 0) result *= -1; // Если отрицательное значение переводим в положительное
    Console.WriteLine(result);
}

int CheckNumber(int insertData) // Проверка правильности введенного значения
{
    if (insertData > -100 && insertData < 100 )
    {
        return -1;
    }
    else
    {
        return insertData;
    }

}
