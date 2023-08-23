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
for(int i = 0; i < matrix.GetLength(0); i++) //Параметр 0 определяет, что это строки
{
    for(int j = 0; j < matrix.GetLength(1); j++) //Параметр 1 определяет, что это столбцы
    {
        matrix[i, j] = new Random().Next(1, 10);
        System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
}