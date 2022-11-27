// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
         System.Console.Write($"{matr[i,j]} ");   
        }
    System.Console.WriteLine();
    }
}

void FillArray(int [,] matr )
{
    Random array = new Random();
     for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          matr[i,j] = array.Next(0,5);
        }
    }
}

int [,] matrix1 = new int [2,4];
FillArray(matrix1);
PrintArray(matrix1);
System.Console.WriteLine();
int [,] matrix2 = new int [4,3];
FillArray(matrix2);
PrintArray(matrix2);

bool Control( int [,] matrix1 , int [,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        return true;
    }
    return false;
}

int [,] MultiplicationMatrixs(int [,] matrix1 , int [,] matrix2)
{
    
    int [,] answermatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i=0; i < matrix1.GetLength(0); i++)
    {
        for( int x = 0; x < matrix2.GetLength(1); x++)
        {
            int sum = 0;
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                sum = sum + matrix1[i,j] * matrix2[j,x];
                answermatrix[i,x] = sum;
            }

        }
    }
    return answermatrix;
}

if(Control(matrix1, matrix2))
{
System.Console.WriteLine(" Произведением двух матриц будет матрица: ");
int [,] answer = MultiplicationMatrixs(matrix1 , matrix2);
PrintArray(answer);
}
else
{
    System.Console.WriteLine("Матрицы нельзя умножить");
}
