using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZjatkovDV.Sprint6.Task5.V14.Lib
{
    public class DataService : ISprint6Task5V14
    {
        public double[] LoadFromDataFile(string path)
        {
            return File.ReadAllText(path)
                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                      .Select(s => Math.Round(double.Parse(s, CultureInfo.InvariantCulture), 3))
                      .Where(s => s >= 10)
                      .ToArray();
        }
    }
}
