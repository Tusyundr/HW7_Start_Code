// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int m, n, arrmax, arrmin;

Console.WriteLine("Введите количество строк массива, m: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбцов массива, n: ");
n  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое значение элемента массива: ");
arrmax  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное допустимое значение элемента массива: ");
arrmin  = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateRandArray(m, n, arrmax, arrmin);
PrintArray(arr, m, n);

Console.WriteLine("введите позицию");
Console.Write("Строка: ");
int coordinat1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int coordinat2 = Convert.ToInt32(Console.ReadLine());

SearchNum(arr, coordinat1, coordinat2, m, n);

//Метод, создающий массив, заполненный случайными числами
int[,] CreateRandArray(int rows, int columns, int max, int min)
{
var array = new int[rows, columns];


for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }    
    }
return array;
}

// Метод, выводящий массив на печать
void PrintArray (int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
        {
          Console.Write(array[i, j] + "\t");  
        }  
    Console.WriteLine();   
    }
}

// Метод, который выдает значение элемента массива
void SearchNum (int[,] array, int coordinaterow, int coordinatecolumn, int arrayrows, int arraycolumns)
{
    if (coordinaterow <= arrayrows && coordinatecolumn <= arraycolumns)
    {
        Console.WriteLine($"Значение искомого элемента массива: " + array[coordinaterow - 1, coordinatecolumn - 1]);
    }
    else Console.WriteLine("Такого элемента в массиве нет");
}