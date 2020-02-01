using System;

namespace zad_6_Matrix
{
	class Matrix
	{
		public int M, N;
		public double[,] matrix;
		public double[,] matrix2;
		public int Rows
		{
			get { return matrix.GetLength(0); }
		}
		public int Column
		{
			get { return matrix.GetLength(1); }
		}
		public Matrix(int m, int n)
		{
			matrix = new double[m, n];
			M = m;
			N = n;
		}
		public void insertData(Matrix m)
		{
			Console.WriteLine("podaj liczbe");

			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					m.matrix[i, j] = double.Parse(Console.ReadLine());
				}
			}
		}
		public Matrix AddMatrix(Matrix m1, Matrix m2)
		{
			Matrix m3 = new Matrix(m1.matrix.GetLength(0), m2.matrix.GetLength(1));

			if ((m1.matrix.GetLength(0) != m2.matrix.GetLength(0)) | (m1.matrix.GetLength(1) != m2.matrix.GetLength(1)))
			{
				Console.WriteLine("Dodawnie niewykonalne");
			}
			else
			{
				for (int i = 0; i < M; i++)
				{
					for (int j = 0; j < N; j++)
						m3.matrix[i, j] = m1.matrix[i, j] + m2.matrix[i, j];
				}
			}
			return m3;
		}

		public double[,] MultipleMatrix(Matrix m1, Matrix m2)
		{
			int RowsM1 = m1.matrix.GetLength(0);
			int ColumnM1 = m1.matrix.GetLength(1);
			int RowsM2 = m2.matrix.GetLength(0);
			int ColumnM2 = m2.matrix.GetLength(1);
			double tmp;
			double[,] m3 = new double[RowsM1, ColumnM2];
			if (ColumnM1 != RowsM2)
			{
				Console.WriteLine("Mnożenie niewykonalne");
			}
			else
			{
				for (int i = 0; i < RowsM1; i++)
				{
					for (int j = 0; j < ColumnM2; j++)
					{
						tmp = 0;
						for (int k = 0; k < ColumnM1; k++)
						{
							tmp += m1.matrix[i, k] * m2.matrix[k, j];
						}
						m3[i, j] = tmp;
					}
				}
			}
			return m3;
		}
		public int RowsCounter(double[,] m1)
		{
			return m1.GetLength(0);
		}
		public int ColumnCounter(double[,] m1)
		{
			return m1.GetLength(1);
		}

		public string ShowMatrix()
		{
			string s = "";
			for (int x = 0; x < Rows; x++)
			{
				for (int y = 0; y < Column; y++)
				{
					s += String.Format("{0}\t", matrix[x, y]);
				}
				s += '\n';
			}
			return s;
		}
		public Matrix ConstMultipli(Matrix m1, double x)
		{
			Matrix m2 = new Matrix(m1.Rows, m1.Column);
			for (int i = 0; i < m1.Rows; i++)
			{
				for (int j = 0; j < m1.Column; j++)
				{
					m2.matrix[i, j] = m1.matrix[i, j] * x;
				}
			}
			return m2;
		}

	}
}
