// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
Console.WriteLine("задача 47");
Console.Write("введите количество столбцов m: ");//3
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество строк n: ");//2
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[n, m];//[3,2]
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().NextDouble() * 10;
        array[i, j] = Math.Round(array[i, j], 2);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

