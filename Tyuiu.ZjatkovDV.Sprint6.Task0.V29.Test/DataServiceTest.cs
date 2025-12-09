using Tyuiu.ZjatkovDV.Sprint6.Task0.V29.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task0.V29.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.Equal(0.722, result.Calculate(3));
        }
    }
}