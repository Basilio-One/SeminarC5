// Задача 31: Задайте массив из N элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int [] CreateArray (int size)
{
    int[]array = new int[size];
    for(int i=0; i<size; i++) 
        array[i] = new Random().Next(-9, 10);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array) 
        Console.Write($"{el} ");
    Console.WriteLine();
}

void FindSums(int[]array)
{
    int sum_p = 0; 
    int sum_n = 0; 

    foreach (int el in array)
    {
        if(el>0) sum_p+=el;
        else sum_n+=el;
    }
    Console.WriteLine($"Сумма положительных чисел равна {sum_p} ");
    Console.WriteLine($"Сумма отрицательных чисел равна {sum_n} ");
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[]array = CreateArray(size);  // создали массив
PrintArray(array);  // распечатали на экран
FindSums(array);  // нашли суммы
