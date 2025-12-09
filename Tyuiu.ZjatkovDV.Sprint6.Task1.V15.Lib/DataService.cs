using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZjatkovDV.Sprint6.Task1.V15.Lib
{
    public class DataService : ISprint6Task1V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];

            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;
                double functionValue;

                if (x - 0.7 == 0)
                {
                    functionValue = 0;
                }
                else
                {
                    functionValue = Math.Cos(x) / (x - 0.7) - Math.Sin(x) * 12*x + 2;
                }

                results[i] = Math.Round(functionValue, 2);
            }

            return results;
        }
    }
}
