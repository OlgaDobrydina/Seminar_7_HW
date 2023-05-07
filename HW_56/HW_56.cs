// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива ");
int column = int.Parse(Console.ReadLine());
int[,] mass = MassNumbers(row, column);
PrintMass(mass);
LineSumma(mass);





int[,] MassNumbers(int row, int column)
{
    int[,] array = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rand.Next(1, 10);
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

void LineSumma(int[,] array)
{
    int temp = int.MaxValue;
    int index = 0;
    for (int i = 0; i < row; i++)
    {
        int sum = 0;
        for (int j = 0; j < column; j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < temp)
        {
            temp = sum;
            index = i;
        }
    }
    Console.WriteLine("Строка: " + index + " Сумма - " + temp);   
    
 }




