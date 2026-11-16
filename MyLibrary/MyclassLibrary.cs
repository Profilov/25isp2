namespace MyLibrary
{
    public class MyclassLibrary
    {
        public static  long MultiMatrix(int[] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.Length; i++) sum += matrix[i];
            return sum;
        }
    }
}
