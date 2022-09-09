/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Задача HARD SORT.
Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
Например, задан массив:
1 4 7 2
5 9 10 3
После сортировки
1 2 3 4
5 7 9 10
*/
void PrintArray(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] FillRealArray(int m, int n)
{
    double intNumber = 0;
    double doubleNumber = 0;
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intNumber = new Random().Next(1, 100);
            doubleNumber = Math.Round(new Random().NextDouble(), 2);
            array[i, j] = intNumber + doubleNumber;
        }
    }
    return array;
}
string CheckElement(int row, int collum, double[,] array)
{
    try
    {
        return $"Значение элемента с индексами {row} {collum} = {array[row, collum]}";
    }
    catch
    {
        return "такого числа в массиве нет";
    }
}
Console.WriteLine("Задача 1");
Console.Write("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] mas = FillRealArray(m, n);
PrintArray(mas);
Console.WriteLine("Задача 2");
Console.Write("Введите индекс строки ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца ");
int collum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckElement(row,collum,mas));