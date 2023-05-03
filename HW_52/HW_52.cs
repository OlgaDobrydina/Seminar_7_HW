//  Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива ");
int column = int.Parse(Console.ReadLine());
int[,] mass = MassNumbers(row, column);
PrintMass(mass);
ColumnSum(mass, row);




int[,] MassNumbers(int row, int column)
{

    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(1, 10);
    return array;
}

void PrintMass(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{array[i, j],4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ColumnSum(int[,] array, int row)
{
    int rownumber = array.GetLength(0);
    int column = array.GetLength(1);
    int a = row;

    for (int j = 0; j < column; j++)
    {
        double sum = 0;
        for (int i = 0; i < rownumber; i++)
        {
            sum = sum + array[i, j];
        }
        double aver = sum / a;
        Console.Write(aver + "; ");
    }
}
