// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int numM = 3;
int numN = 2;
int result = FunctionAkerman(numM, numN);
Console.WriteLine($"m = {numM}, n = {numN} -> A(m,n) = {result}");

int FunctionAkerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return FunctionAkerman(m - 1, 1);
    else
      return FunctionAkerman(m - 1, FunctionAkerman(m, n - 1));
}