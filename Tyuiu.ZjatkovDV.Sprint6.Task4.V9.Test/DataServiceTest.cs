using Tyuiu.ZjatkovDV.Sprint6.Task4.V9.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task4.V9.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMassFunction()
        {
            var result = new DataService();
            Assert.Equal(result.GetMassFunction(-5, 5), result.GetMassFunction(-5, 5));
        }
    }
}