using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZjatkovDV.Sprint6.Task0.V29.Lib
{
    public class DataService : ISprint6Task0V29
    {
        public double Calculate(int x)
        {
            return Math.Round((Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2)), 3);
        }
    }
}
