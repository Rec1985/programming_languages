// Задача 36: Задайте одномерный массив,  
// заполненный случайными числами. Найдите сумму элементов,  
// стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0 
 
int[] mass = CreateArrayRndInt(4, 100, 999); 
PrintArray(mass); 
int result = CountEvenNumbers(mass); 
Console.Write(" -> "); 
Console.Write(result); 
 
int CountEvenNumbers(int[] array) 
 { 
    int sum = 0; 
    for (int i = 1; i < array.Length; i += 2) 
    { 
       sum += array[i];  
    } 
    return sum; 
 }  
 
int[] CreateArrayRndInt (int size, int min, int max) 
{ 
    int[] array = new int[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i] = rnd.Next(min, max + 1); 
    } 
    return array; 
} 
 
void PrintArray (int[] massive) 
{ 
    Console.Write("["); 
    for (int i = 0; i < massive.Length; i++) 
    { 
        if(i < massive.Length - 1) Console.Write($"{massive[i]}, "); 
        else Console.Write($"{massive[i]}"); 
    } 
    Console.Write("]"); 
}
