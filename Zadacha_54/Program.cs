Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];

 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i,j]+"\t");
        }
        Console.WriteLine();        
    }
    
Console.WriteLine();


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) ; j++)
    {     
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            if (matrix[i, k] < matrix[i, k + 1]) 
            {             
               
                int temp = matrix[i, k+1];
                matrix[i, k+1] = matrix[i, k ];
                matrix[i, k ] = temp;                
            }           
        }        
    }    
}
  for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]  +"\t");
        }        
        Console.WriteLine("");
    }