// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void FillArray(float [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,100);
    }
}

void PrintArray(float []array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void MaxMinDifference(float [] array)
{
    float max = float.MinValue;
    float min = float.MaxValue;
    float sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    sum = max-min;
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {sum}");
}

float [] array = new float [5];
FillArray(array);
PrintArray(array);
MaxMinDifference(array);