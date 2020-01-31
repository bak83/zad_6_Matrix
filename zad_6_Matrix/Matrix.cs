using System;

namespace zad_6_Matrix
{
	class Matrix
	{
		public int M, N;
		public double[,] matrix;
		public double[,] matrix2;
		public Matrix(int m, int n)
		{
			matrix = new double[m, n];
			M = m;
			N = n;
		}
		public void insertData(double[,] matrix)
		{
			Console.WriteLine("podaj liczbe");

			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					matrix[i, j] = double.Parse(Console.ReadLine());
				}
			}
		}
		public double[,] AddMatrix(double[,] m1, double[,] m2)
		{
			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
					matrix[i, j] = m1[i, j] + m2[i, j];
			}

			return matrix;
		}

		public double[,] MultipleMatrix(double[,] m1, double[,] m2)
		{
			int RowsM1 = m1.GetLength(0);
			int ColumnM1 = m1.GetLength(1);
			int RowsM2 = m1.GetLength(0);
			int ColumnM2 = m1.GetLength(1);
			double[,] m3 = new double[RowsM1, ColumnM2];
			if (ColumnM1 != RowsM2)
			{
				Console.WriteLine("Niewykonalne");
			}
			else
			{
				for (int i = 0; i < RowsM1; i++)
				{
					for (int j = 0; i < ColumnM2; j++)
					{
						for (int k = 0; k < ColumnM1; k++)
						{

						}
					}
				}
			}
			return m3;
		}
	}
}
