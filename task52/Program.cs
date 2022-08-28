/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using System;
class Program
{
static void FillArray(int[,] matr)
{
	for(int i = 0; i < matr.GetLength(0); i++)  // кол-во строк
	{
		for(int j = 0; j < matr.GetLength(1); j++) // кол-во столбиков
		{
			matr[i, j]= new Random().Next(1, 11); //
		}
	}
}
static void PrintArray(int[,] matr)
{
		for(int i = 0; i < matr.GetLength(0); i++)  // кол-во строк
	{
			for(int j = 0; j < matr.GetLength(1); j++) // кол-во столбиков
		{
			Console.Write($"{matr[i, j]} ");
		}
		Console.WriteLine();
	}
}

static void Main(string[] args)
{
	Console.WriteLine();
	Console.Write("Введите количество строк двумерной матрицы: m = ");
	int m = Convert.ToInt32(Console.ReadLine()); 
	Console.Write("Введите количество столбиков двумерной матрицы: n = ");
	int n = Convert.ToInt32(Console.ReadLine());

	int[,] matrix = new int [m, n];
	Console.WriteLine();
	Console.WriteLine("Задан массив: ");
	FillArray(matrix);
	PrintArray(matrix);
	
	double [] sum = new double [n];
	double [] res = new double [n];
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			sum [i] += matrix[j,i];
		}
		res [i] = (sum [i])/m;	
		Console.WriteLine($"Среднее арифметическое {1+i} столбца = {Math.Round((res [i]),1)}.");
	}
	Console.WriteLine();
}
}