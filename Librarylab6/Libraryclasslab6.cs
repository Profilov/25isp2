namespace Librarylab6
{
    public class Libraryclasslab6
    {
        public static long MultiMatrix(int[,] matrix)
        {
            int max = matrix[0, 0];
            int min = matrix[0, 0];
            int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < size; i++)
            {
                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                }
                if (matrix[i, i] < min)
                {
                    min = matrix[i, i];
                }
            }
            return (long)max + min;
        }
    }
}
