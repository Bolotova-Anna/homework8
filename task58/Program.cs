// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
//  произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
void GenerateNewMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
        if (matrix1.GetLength(0)==matrix2.GetLength(1) && matrix1.GetLength(1)==matrix2.GetLength(0))
        {
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
             for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                  int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                     {
                       sum +=matrix1[i,k]*matrix2[k,j];
                     }
                matrix3[i,j] = sum;
                }
        
            } 
        }
        else if (matrix1.GetLength(0)==matrix2.GetLength(0) && matrix1.GetLength(1)==matrix2.GetLength(1))
        {
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
             for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i,j] = matrix1[i,j]*matrix1[i,j];
            }
            }
        }
        else
        {
            System.Console.WriteLine("ошибка");
        }
}
int m = Read("введите количество строк для первой матрицы");
int n = Read("введите количество столбцов для первой матрицы");
int[,] matrix1 = FillMatrix(m, n);
PrintMatrix(matrix1);
System.Console.WriteLine();
int k = Read("введите количество строк для второй матрицы");
int l = Read("введите количество столбцов для второй матрицы");
int[,] matrix2 = FillMatrix(k, l);
PrintMatrix(matrix2);
System.Console.WriteLine();
// if (matrix1.GetLength(0)==matrix2.GetLength(1) && matrix1.GetLength(1)==matrix2.GetLength(0))
//     {
//         int[,] matrix3 = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
//     }
//     else if (matrix1.GetLength(0)==matrix2.GetLength(0) && matrix1.GetLength(1)==matrix2.GetLength(1));
//     {
//         int[,] matrix3 = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
//     }
int[,] matrix3 = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
GenerateNewMatrix(matrix1, matrix2, matrix3);
PrintMatrix(matrix3);