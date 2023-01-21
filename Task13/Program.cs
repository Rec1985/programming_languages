// Task13:
//     Напишите программу, которая выводит 
//     третью цифру заданного числа или сообщает, что 
//     третьей цифры нет. Выполнить с помощью числовых 
//     операций (целочисленное деление, остаток от деления).

//     645 -> 5
//     78 -> третьей цифры нет
//     32679 -> 6
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
