// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



// int NumBinary(int number)
// {
//     int numberBin = 0;
//     int count = 1;
//     while (number > 0)
//     {
//         numberBin = numberBin + (number % 2 * count);
//         number /= 2;
//         count *= 10;
//     }
//     return numberBin;
// }

// Console.Write("Введите число: ");
// int num;
// if (int.TryParse(Console.ReadLine(), out num))
// {
//     if (num >= 0)
//     {
//     int result = NumBinary(num);
//     Console.WriteLine(result);
//     }
//     else Console.WriteLine("Введено отрицательное число.");
// }
// else Console.WriteLine("Введено некорректное значение.");
