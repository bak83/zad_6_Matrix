﻿using System;

namespace zad_6_Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			double[,] M = new double[2,3];
			Matrix m1 = new Matrix(2,3);
			Console.WriteLine("Maxierz pierwsza: ");
			m1.insertData(m1.matrix);

			Matrix m2 = new Matrix(2, 3);
			Console.WriteLine("Maxierz pierwsza: ");
			m1.insertData(m2.matrix);



			Console.WriteLine(M.GetLength(0));
			Console.WriteLine(M.GetLength(1));
			Console.WriteLine(m1.matrix[0, 0]);

			Console.WriteLine("dupa");
			Console.ReadKey();
		}
	}
}