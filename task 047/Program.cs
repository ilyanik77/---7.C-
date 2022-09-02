// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateArray (int n, int m)
{
    double [,] arr = new double[n, m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = new Random().NextDouble();
        }
    }
    return arr;
}

double [,] matrix = CreateArray(3, 4);

void PrintArray (double [,] arr)
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

PrintArray(matrix);