using System;

namespace zad_6_Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			//double[,] M = new double[2,3];
			var m1 = new Matrix(2, 2);
			Console.WriteLine("Macierz pierwsza: ");
			m1.insertData(m1);
			Console.WriteLine("Twoja macierz:");
			Console.WriteLine(m1.ShowMatrix());

			var m2 = new Matrix(2,2);
			Console.WriteLine("Macierz druga: ");
			m2.insertData(m2);
			Console.WriteLine("Twoja macierz:");
			Console.WriteLine(m2.ShowMatrix());

			//Matrix m3 = new Matrix(2, 2);
			//m3.matrix = m3.AddMatrix(m1, m2);
			//Console.WriteLine("Wynik dodawania, twoja macierz:");
			//Console.WriteLine(m3.ShowMatrix());
			var m3 = m1.AddMatrix(m1, m2);
			Console.WriteLine("Wynik dodawania, twoja macierz:");
			Console.WriteLine(m3.ShowMatrix());

			//var a = m1.ColumnCounter(m1.matrix);
			////var b = m2.RowsCounter(m2.matrix);
			Matrix m4 = new Matrix(m1.ColumnCounter(m1.matrix), m2.RowsCounter(m2.matrix));
			m4.matrix = m4.MultipleMatrix(m1, m2);
			Console.WriteLine("Wynik mnożenia, twoja macierz:");
			Console.WriteLine(m4.ShowMatrix());

			var m5 = m1.ConstMultipli(m1, 2.5);
			Console.WriteLine("Mnożenie przez stałą:");
			Console.WriteLine(m5.ShowMatrix());

			//Console.WriteLine(m4.matrix[0, 0]);
			//Console.WriteLine(m4.matrix.GetLength(0).ToString(), m4.matrix.GetLength(1).ToString());
			//Console.WriteLine(M.GetLength(0));
			//Console.WriteLine(M.GetLength(1));
			Console.WriteLine(m3.matrix[0, 0]);

			Console.WriteLine("dupa");
			Console.ReadKey();
		}
	}
}
