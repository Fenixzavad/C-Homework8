// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов




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

int SumElementsMatrix(int [,] matrix, int line)
{
    int sum = 0;
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
        sum = sum + matrix[line,n];
    }
    return sum;
}

int MinSumElementsLine(int [,] matrix)
{
    int minSum = SumElementsMatrix(matrix, 0);
    int minLine = 0;
    for( int m = 0; m< matrix.GetLength(0); m++)
    {
        if(SumElementsMatrix(matrix, m) < minSum)
        {
            minSum = SumElementsMatrix(matrix, m);
            minLine = m;
        }
    }
    return minLine;
}

int [,] matr = new int [4,4];
FillArray(matr);
PrintArray(matr);
System.Console.WriteLine();
System.Console.WriteLine($"Строка с минимальной суммой элементов строки матрицы: {MinSumElementsLine(matr)} ");

