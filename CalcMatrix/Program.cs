namespace CalcMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Matrix a = CreateMatrix("A");
                Matrix b = CreateMatrix("B");

                Console.WriteLine("\nВыберите операцию:\n1. Сложение\n2. Вычитание\n3. Умножение");
                int choice = ReadConsole("Ваш выбор: ");

                Matrix result = choice switch
                {
                    1 => a + b,
                    2 => a - b,
                    3 => a * b,
                    _ => throw new InvalidOperationException("Неверная операция.")
                };

                Console.WriteLine($"\nРезультат: \n{result}");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        
        }

        private static Matrix CreateMatrix(string matrixName)
        {
            Console.WriteLine($"Матрица {matrixName}");
            int rows = ReadConsole("Количество строк матрицы:");
            int cols = ReadConsole("Количество столбцов матрицы:");

            Matrix matrix = new Matrix(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = ReadElement($"Элемент [{i + 1}, {j + 1}]:");
                }
            }

            return matrix;
        }

        private static double ReadElement(string element)
        {
            double value;
            Console.Write(element);
            while (!double.TryParse(Console.ReadLine(), out value))
                Console.Write("Ошибка! Введите число:");
            return value;
        }

        private static int ReadConsole(string rowsMatrix)
        {
            int value;
            Console.Write(rowsMatrix);

            while (!int.TryParse(Console.ReadLine(), out value) || value <=0)
                Console.Write("Ошибка! Введите целое положительное число:");

            return value;
        }
    }
}
