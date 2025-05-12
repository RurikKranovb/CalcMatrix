using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMatrix
{
   public class Matrix
    {
        public int Rows { get; }
        public int Columns { get; }

        private readonly double[,] data;


        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a is null || b is null)
                throw new ArgumentException("Пустое значение матрицы");
            if (a.Rows != b.Rows || a.Columns != b.Columns)
                throw new ArgumentException("Матрицы должны быть одного размера");

            Matrix result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a is null || b is null)
                throw new ArgumentException("Пустое значение матрицы");
            if (a.Rows != b.Rows || a.Columns != b.Columns)
                throw new ArgumentException("Матрицы должны быть одного размера");

            Matrix result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a is null || b is null)
                throw new ArgumentNullException("Пустое значение матрицы.");
            if (a.Columns != b.Rows)
                throw new ArgumentException("Несовместимые размеры матриц.");

            Matrix result = new Matrix(a.Rows, b.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    for (int k = 0; k < a.Columns; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
                throw new ArgumentException("Ошибка! Размер матрицы не может быть отрицательным.");

            Rows = rows;
            Columns = cols;
            data = new double[rows, cols];
        }

        public double this[int row, int column]
        {
            get => data[row, column];
            set => data[row, column] = value;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                    sb.Append($"{data[i, j],8:F2}"); //отображение шириной 8 символов и 2 знака после запятой
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}

