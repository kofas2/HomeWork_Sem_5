// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99,1000);
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

int CheckEven(int [] array,int sum)
{
    // int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            sum += 1;
        }
    }
    return sum;
}



Console.WriteLine("Введите количество значений массива");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
int sum = 0;
FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество чётных значений в данном массиве равно {CheckEven(array, sum)}");