//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:


using System;
class Program
{
static void FillArray(int[,] matr)
{
	for(int i = 0; i < matr.GetLength(0); i++)  // кол-во строк
	{
		for(int j = 0; j < matr.GetLength(1); j++) // кол-во столбиков
		{
			matr[i, j]= new Random().Next(0, 18); //
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
	int[,] matrix = new int [4, 3];
	Console.WriteLine();
	Console.Write("Введите индекс строки элемента двумерной матрицы: row = ");
	int row = Convert.ToInt32(Console.ReadLine()); 
	Console.Write("Введите индекс столбца элемента двумерной матрицы: column = ");
	int column = Convert.ToInt32(Console.ReadLine());
	FillArray(matrix);
	PrintArray(matrix);
	int result = 0;
	if(row >= matrix.GetLength(0) || column >= matrix.GetLength(1) || row < 0 || column < 0) 
	{
		Console.Write("Такого числа в массиве нет.");
		
	} else
	{
		result = matrix[row,column];
		Console.Write("Значение элемента двумерного массива, согласно введенных индексов строки и столбца = " + result + ".");
		Console.WriteLine();
	}
	
}

}