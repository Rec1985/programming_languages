// Задача 38: Задайте массив вещественных чисел.  
// Найдите разницу между максимальным и минимальным элементами массива. 
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 
 
double[] generateArray = CreateArrayRndIntDouble(4, 0, 100); 
double max = OutArrayMax(generateArray); 
double min = OutArrayMin(generateArray); 
double result = max - min; 
PrintArrayDouble(generateArray); 
Console.Write(" -> "); 
Console.Write(result); 
 
 
 
double OutArrayMax(double[] arr) 
{ 
    double max = arr[0]; 
    for (int i = 0; i < arr.Length; i++) 
    { 
        if(arr[i] > max) max = arr[i]; 
    } 
    return max; 
} 
 
double OutArrayMin(double[] arr) 
{ 
    double min = arr[0]; 
    for (int i = 0; i < arr.Length; i++) 
    { 
        if(arr[i] < min) min = arr[i]; 
    } 
    return min; 
} 
 
double[] CreateArrayRndIntDouble (int size, int min, int max) 
{ 
    double[] array = new double[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++) 
    { 
        double num = rnd.NextDouble() * (max - min) + min; 
        array[i] = Math.Round(num, 1); 
    } 
    return array; 
} 
 
void PrintArrayDouble (double[] massive) 
{ 
    Console.Write("["); 
    for (int i = 0; i < massive.Length; i++) 
    { 
        if(i < massive.Length - 1) Console.Write($"{massive[i]}, "); 
        else Console.Write($"{massive[i]}"); 
    } 
    Console.Write("]");
}
