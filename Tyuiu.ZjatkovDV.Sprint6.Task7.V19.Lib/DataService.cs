using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZjatkovDV.Sprint6.Task7.V19.Lib
{
    public class DataService : ISprint6Task7V19
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rowCount = lines.Length;

            string[] firstLineValues = lines[0].Split(';');
            int colCount = firstLineValues.Length;

            int[,] matrix = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(values[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                }
            }

            return matrix;

        }
    }
}
