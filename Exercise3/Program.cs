// Задача 3: Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Prompt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int[,] FillRandomArray(int row, int column, int min, int max)
{
    var rnd = new Random();
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}

double[] CalculateAverageColumn(int[,] array)
{
    double Sum = 0;
    double[] columns = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Sum = Sum + array[i, j];
        }
        columns[j] = Sum / array.GetLength(0);
    }
    return columns;
}

void PrintColumnAverage(double[] list)
{
    Console.WriteLine("Среднее арифметическое элементов в стобцах равно ");
    foreach (double el in list)
    {
        Console.Write($"{el:f1}" + "\t");
    }
    Console.WriteLine();
}

int n = Prompt("Введите количество строк");
int m = Prompt("Введите количество столбцов ");
int min = Prompt("Введите минимальное число для массива ");
int max = Prompt("Введите максимальное число для массива  ");

int[,] myArray = FillRandomArray(n, m, min, max);
PrintArray(myArray);
System.Console.WriteLine();
PrintColumnAverage(CalculateAverageColumn(myArray));