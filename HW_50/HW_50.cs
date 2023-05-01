// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк массива ");
int rownum = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива ");
int columnnum = int.Parse(Console.ReadLine());
Console.Write("Введите искомое число ");
int number = int.Parse(Console.ReadLine());
int[,] mass = MassNumbers(rownum, columnnum);
PrintMass(mass);
PrintNumbers(mass, number);


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
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {array[i, j]} ");
        Console.WriteLine();    
    }
    Console.WriteLine();      
}

void PrintNumbers(int[,] array, int number)
{
	    int row = array.GetLength(0);
	    int column = array.GetLength(1);
	
	    for (int i = 0; i < row; i++)
	    {
	        for (int j = 0; j < column; j++)
	        {
	            if (number == array[i, j])
	            {
	                Console.WriteLine($"{i + 1}, {j + 1}");
	                return;
	            }
	        }
	    }
	    Console.WriteLine("Нет такого числа в массиве");
    
}