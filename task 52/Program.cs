// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
ArithMean(arr, m, n);


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

//Метод, который находит среднее арифметическое элементов в каждом столбце
void ArithMean(int[,] array, int rows, int columns)
{
Console.WriteLine("Среднее арифметическое элементов в столбцах:");

    double arithmeticalmean = 0;

    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            arithmeticalmean += array[i, j];
        }
        arithmeticalmean = Math.Round(arithmeticalmean / rows, 1);
        Console.Write(arithmeticalmean + "\t");
        arithmeticalmean = 0;
    }
    Console.WriteLine();
}