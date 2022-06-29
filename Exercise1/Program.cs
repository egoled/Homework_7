// // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[,] FillRealNumberArray(int m, int n)
{
    var array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble() + new Random().Next(-100, 100);
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0,6:F2} ", array[i, j]);
        }
        System.Console.WriteLine();
    }
}


int m = Prompt("Введите количество строк >");
int n = Prompt("Введите количество столбцов >");

double[,] array = FillRealNumberArray(m, n);
PrintArray(array);
System.Console.WriteLine();