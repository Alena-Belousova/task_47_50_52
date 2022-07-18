// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("задача 52");
Console.Write("задайте количество строк массива: ");
int NumberOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте количество столбцов массива: ");
int numberofcolumns = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;

int[,] array = new int[NumberOfLines, numberofcolumns];
for (i = 0; i < array.GetLength(0); i++)
{
    for (j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");

    }
    Console.WriteLine();
}
Console.Write("среднее по столбцам: ");
for (j = 0; j < array.GetLength(1); j++)
{
    int sum = 0;
    for (i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, j];
    }
    double Srednee = sum / NumberOfLines;

    //Console.WriteLine("среднее: ");
    Console.Write(Srednee + "; ");
}


