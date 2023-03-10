// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой 
//  элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
int Read(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] FillMatrix(int m, int n)
{
    Random rand = new Random();
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(1,9);
        }
        
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           System.Console.Write(matrix[i,j]+ "\t");
        }
        System.Console.WriteLine();
    }
}
int[] SumString(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        array[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] = array[i]+matrix[i,j];
        }   
    }
    return array;
}
void ShowMinIndex(int[] array)
{
    int min = array[0];
    int minindex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<min)
        {
            min = array[i];
            minindex = i;
        }
    }
    System.Console.WriteLine("строка с наименьшей суммой элементов: " + minindex);
}
int m = Read("введите количество строк");
int n = Read("введите количество столбцов");
int[,] mymatrix = FillMatrix(m, n);
PrintMatrix(mymatrix);
System.Console.WriteLine();
int[] myarray = SumString(mymatrix);
System.Console.WriteLine("["+ String.Join(",", myarray)+"]");
ShowMinIndex(myarray);