// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int  j= 0;  j< matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i,k]<matrix[i,k+1])
            {
                int some = matrix[i,k+1];
                matrix[i,k+1] = matrix[i,k];
                matrix[i,k] = some;
            }
            }
        }
    }
}
int m = Read("введите количество строк");
int n = Read("введите количество столбцов");
int[,] mymatrix = FillMatrix(m, n);
PrintMatrix(mymatrix);
System.Console.WriteLine();
ChangeMatrix(mymatrix);
PrintMatrix(mymatrix);
