// Задайте двумерный массив. Напишите программу, которая упорядочивает
//  по убыванию элементы каждой строки двумерного массива.

void PrintArray(int [,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
         System.Console.Write($"{matrix[m,n]} ");   
        }
    System.Console.WriteLine();
    }
}

void FillArray(int [,] matrix )
{
    Random array = new Random();
     for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
          matrix[m,n] = array.Next(0,5);
        }
    }
}

int [,] DescendingArray( int [,] matrix)
{
    for(int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int index = 0; index <= matrix.GetLength(0); index++)
    {
        int min = matrix[m, index];
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            if(matrix[m,n] < min)
            {
                min = matrix[m,n];
                matrix[m,n] = matrix[m,index];
                matrix [m,index]=min;
            }
        }
    }
    }
    return matrix;
}

int [,] matr = new int [3,4];
FillArray(matr);
PrintArray(matr);
System.Console.WriteLine();
int [,] answermatr = DescendingArray(matr);
PrintArray(answermatr);
