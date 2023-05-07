// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк массива ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива ");
int column = int.Parse(Console.ReadLine());
int[,] mass = MassNumbers(row, column);
PrintMass(mass);
MatrixToArray(mass);


int[,] MassNumbers(int row, int column)
{
    int[,] array = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rand.Next(1, 100);
        }
    }
    return array;
}

void PrintMass(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MatrixToArray(int[,] array)
{
    int[] matrix = new int[column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[j] = array[i, j];
            Console.Write(matrix[j] + " ");
        }        
        Console.WriteLine();
        
    }
}


