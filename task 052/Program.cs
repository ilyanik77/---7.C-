// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateArray (int n, int m)
{
    int [,] arr = new int [n, m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = new Random().Next(1, 100);
        }
    }
    return arr;
}

void PrintArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr [i, j]}\t");
        }
        Console.WriteLine();
    }
    
}

void Sum (int [,] arr)
{
    int result = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
            result = sum / arr.GetLength(0); 
        }
        Console.Write($"{result}\t"); //Выводим средне-арифметическое под каждым столбцом.
    }
}

int [,] matrix = CreateArray(3, 4);
PrintArray(matrix);
Console.WriteLine("--------------------------");
Sum(matrix);