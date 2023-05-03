// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк массива ");
int rownum = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива ");
int columnnum = int.Parse(Console.ReadLine());
double[,] mass = MassNumbers(rownum, columnnum);
PrintMass(mass);



double[,] MassNumbers(int row, int column)
{
    double[,] array = new double[row, column];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rand.NextDouble();
        }
    }
    return array;
}

void PrintMass(double[,] array)
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