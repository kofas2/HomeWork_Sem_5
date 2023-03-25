﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,100);
    }
}

void PrintArray(int []array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void SumNegativeNum(int [] array)
{
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2!=0)
        {
            sumNegative += array[i];
        }

    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна: {sumNegative}");
}




Console.WriteLine("Введите количество значений массива");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
FillArray(array);
PrintArray(array);
SumNegativeNum(array);