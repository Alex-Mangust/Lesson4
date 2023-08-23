// string[,] table = new string[2, 3];
// // table[0,0] table[0,1] table[0,2] 
// // table[1,0] table[1,1] table[1,2]
// table[1, 2] = "Слово";
// for(int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 3; columns++)
//     {
//         System.Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

int[,] matrix = new int[3, 4];
void InputArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
    System.Console.WriteLine();
    }
}
PrintArray(matrix);
System.Console.WriteLine();
InputArray(matrix);
PrintArray(matrix);