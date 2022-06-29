// Задача 2: Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет



int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var rand = new Random();
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max + 1);
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
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int [] FindElementPosition (int [,] array, int rowPosition, int columnPosition)
{   
    int [] number={0,-1};
    if ((rowPosition-1)<=array.GetLength(0) && (columnPosition-1)<=array.GetLength(1))
    {
        number[1]=0;
        number[0]=array[rowPosition-1,columnPosition-1];
        return number;
    }
    return number;
}
void PrintNumber (int[] result, int m, int n)
{
    if (result[1]==-1){Console.WriteLine("Такого числа нет");}
    else {Console.WriteLine($"Число по координатам [{m}, {n}] равно {result[0]}");
    }
}

int row = Prompt ("Введите количество строк >");
int column = Prompt("Введите количество столбцов >");
int min = Prompt("Введите минимальное значение элемента в массиве >");
int max = Prompt("Введите максимальное значение элемента в массиве >");
int i = Prompt ("Введите позицию элемента в строке");
int j = Prompt ("Введите позицию элемента в столбце");


int [,] myArray = GenerateArray(row,column,min,max);

PrintArray(myArray);

PrintNumber(FindElementPosition(myArray, i, j),i,j);
