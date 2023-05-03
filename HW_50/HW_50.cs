// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк массива ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите номер строки ");
int rownum = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца ");
int columnnum = int.Parse(Console.ReadLine());
int[,] mass = MassNumbers(row, column);
PrintMass(mass);
PrintNumbers(mass, rownum, columnnum);


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

void PrintNumbers(int[,] array, int rownum, int columnnum)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int a = rownum;
    int b = columnnum;
    int i = 0;
    int j = 0;

    if (a > row | b > column) Console.WriteLine("Нет");
    else 
    {
        i = a; j = b;
        Console.WriteLine(array[i-1,j-1]);
    }
    
}