// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m, n;
double arrmax, arrmin;

Console.WriteLine("Введите количество строк массива, m: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбцов массива, n: ");
n  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое значение элемента массива: ");
arrmax  = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите минимальное допустимое значение элемента массива: ");
arrmin  = Convert.ToDouble(Console.ReadLine());

double[,] arr = CreateRandArray(m, n, arrmax, arrmin);
PrintArray(arr, m, n);


//Метод, создающий массив, заполненный случайными вещественными числами
double[,] CreateRandArray(int rows, int columns, double max, double min)
{
var array = new double[rows, columns];

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble();
            array[i, j] = array[i, j] * (max - min) + min;
            array[i, j] = Math.Round(array[i, j], 2); 
        }    
    }
return array;
}

// Метод, выводящий массив на печать
void PrintArray (double[,] array, int rows, int columns)
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