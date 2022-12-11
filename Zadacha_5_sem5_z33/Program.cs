// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArray(int size) 
{ 
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++) 
        array[i] = new Random().Next(-9, 10); 
    return array; 
} 
 
void PrintArray(int[] array) 
{ 
    foreach (int el in array) 
        Console.Write($"{el} "); 
    Console.WriteLine(); 
} 
 
 
bool FindNum(int[] array, int num) 
{ 
    bool res = false; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] == num) 
        { 
            res = true; 
            break; 
        } 
    } 
    return res; 
} 
 
// void FindNum (int[] array, int num) 
// { 
//     int count = 0; 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         if (array[i] == num) count = count +1; 
//     } 
//     if (count > 0) Console.WriteLine("ДА, Число присутствует в массиве!"); 
//     else Console.WriteLine("НЕТ! Искомого числа"); 
// } 
 
Console.WriteLine("Введите размерность массива"); 
int size = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Введите искомое число: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
 
int[] array = CreateArray(size); 
PrintArray(array); 
if (FindNum(array, num)) Console.WriteLine("ДА, Число присутствует в массиве!"); 
else Console.WriteLine("НЕТ! Искомого числа");