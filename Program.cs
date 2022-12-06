//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*double[,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    double[,] createdArray = new double[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            createdArray[i, j] = Math.Round(new Random().Next(minVal, maxVal + 1) + new Random().NextDouble(),3);
    return createdArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Imput count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] newArray = Create2dArray(rows,columns,min,max);
Show2dArray(newArray);
*/

 //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*int[,]Create2dArray(int row, int column)
{
    int[,] createdArray = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            createdArray[i, j] = new Random().Next(1,10);
    return createdArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int Coordinat(int[,] array, int row, int column)
{
    int coor = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == row && j == column) coor = +array[i, j];
    return coor;
}

Console.WriteLine("Imput row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput column: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] newArray = Create2dArray(3,4);
Show2dArray(newArray);
int num = Coordinat(newArray,row,column);
if (num != 0)
Console.WriteLine($"Result is {num}");
else
Console.WriteLine($"The position does not exist!");
*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*int[,] Create2dArray(int rows,int columns,int min,int max)
{
    int[,] newArray = new int[rows,columns];
    for(int i = 0;i<rows;i++)
    {
        for(int j = 0;j< columns;j++)
        {
            newArray[i,j] = new Random().Next(min,max+1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] AvgColumn(int[,] array)
{
    double[] avgSum = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
       {
          double sum = 0;
          for(int i = 0;i < array.GetLength(0);i++)
          {
            sum += array[i,j];
          }
          avgSum[j] = Math.Round(sum/array.GetLength(0),2);
       }
       return avgSum;
} 

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");   
}

Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of min: ");
int user_min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of max: ");
int user_max = Convert.ToInt32(Console.ReadLine());

int[,] array2d = Create2dArray(user_rows,user_columns,user_min,user_max);
Show2dArray(array2d);
double[] array1d = AvgColumn(array2d);
ShowArray(array1d);
*/