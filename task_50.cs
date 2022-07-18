// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца.
// Цифры не больше 9.
Console.WriteLine("задача 50");
Console.Write("задайте количество строк: ");
int numberLine = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте количество столбцов: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());
Console.Write("введите два числа от 0 до 9 через запятую: ");
string numbers = Console.ReadLine();
string[] array1 = numbers.Split(',');
int X = Convert.ToInt32(array1[0]);
int Y = Convert.ToInt32(array1[1]);
int[,] array = new int[numberLine, numberColumn];
if (numberColumn < Y || numberLine < X)
{
    Console.WriteLine("ошибка: в массиве нет такой позиции");
}
else
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    int position = array[X, Y];
    Console.WriteLine("искомое число " + position);
}