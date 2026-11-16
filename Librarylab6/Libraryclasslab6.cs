namespace Librarylab6
{
    public class Libraryclasslab6
    {
        public static long MultiMatrix(int[,] matrix)
        {
            int max = 0;
            int min = 0;
            max = matrix[0, 0];
            min = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (matrix[i, j] > max)
                        {
                            max = matrix[i, j];
                        }
                        if (matrix[i, j] < min)
                        {
                            min = matrix[i, j];
                        }
                    }
                }
            }

            return max + min;
        }
    }
}
