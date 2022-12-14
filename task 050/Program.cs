//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void Elem (int [,] arr, int row, int column)
{
    int x = row - 1;
    int y = column - 1;
    if (x > arr.GetLength(0) || y > arr.GetLength(1))
    Console.WriteLine("Такого элемента не существует");
    else        
    Console.Write(arr[x, y]); 
}

int [,] matrix = CreateArray(n, m);
PrintArray(matrix);
Console.WriteLine();
Elem(matrix, row, column);





