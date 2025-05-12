namespace CalcMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix a = CreateMatrix("A");
        }

        private static Matrix CreateMatrix(string matrixName)
        {
            Console.WriteLine($"Матрица {matrixName}");
            int rows = ReadMatrixElement("Количество строк матрицы:");
            int cols = ReadMatrixElement("Количество столбцов матрицы:");

            return null;
        }

        private static int ReadMatrixElement(string rowsMatrix)
        {
            int value;
            Console.Write(rowsMatrix);

            while (!int.TryParse(Console.ReadLine(), out value) || value <=0)
                Console.Write("Ошибка! Введите целое положительное число:");

            return value;
        }
    }
}
