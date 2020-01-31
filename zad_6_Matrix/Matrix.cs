using System;

namespace zad_6_Matrix
{
	class Matrix
	{
		public int M, N;
		public double[,] matrix;
		public Matrix(int m, int n)
		{
			matrix = new double[m, n];
			M = m;
			N = n;
		}
		public void insertData(double [,]matrix)
		{
			Console.WriteLine("podaj liczbe");

			for (int i = 0;i<M;i++)
			{
				for (int j=0;j<N;j++)
				{
					matrix[i, j] = double.Parse(Console.ReadLine());
				}
			}
		}
		public double AddMatrix(double[,] m1, double[,] m2)
		{
			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
					matrix[i, j] = m1[i, j] + m2[i, j];

			}

			return 0;
		}
	}
}
