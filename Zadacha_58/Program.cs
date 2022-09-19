﻿Console.WriteLine("Введите количество строк первой матрицы");
int rows1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int columns1= Convert.ToInt32(Console.ReadLine());
 
int rows2= columns1;
int columns2= rows1;
 
Console.WriteLine("Матрица первая");
int[,]matrix1= new int[rows1,columns1];
for(int i=0; i<matrix1.GetLength(0); i++)
{
    for(int j=0; j<matrix1.GetLength(1); j++)
    {
        matrix1[i,j]= new Random().Next(-50,51);
 
        Console.Write(matrix1[i,j]+"\t");   
    }
Console.WriteLine("");
}
Console.WriteLine("Матрица вторая");
int[,]matrix2= new int[rows2,columns2];
for(int i=0; i<matrix2.GetLength(0); i++)
{
    for(int j=0; j<matrix2.GetLength(1); j++)
    {
        matrix2[i,j]= new Random().Next(-50,51);
 
        Console.Write(matrix2[i,j]+"\t");   
    }
Console.WriteLine();
}  
Console.WriteLine("Произведение матриц");
int[,]matrixAnsver = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
for(int i=0; i<matrix1.GetLength(0); i++)
{
    for(int j=0; j<matrix2.GetLength(1); j++)
    {
        for(int k=0;k<matrix2.GetLength(0);k++)
        {
            matrixAnsver[i,j]+=matrix1[i,k]*matrix2[k,j];
        }
        Console.Write(matrixAnsver[i,j]+"\t");
    }
    Console.WriteLine();
}
