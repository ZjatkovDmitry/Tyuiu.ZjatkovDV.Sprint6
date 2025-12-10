using Tyuiu.ZjatkovDV.Sprint6.Task7.V19.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task7.V19.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMatrix()
        {
            var result = new DataService();
            Assert.Equal(result.GetMatrix("C:\\DataSprint6\\InPutDataFileTask7V19.csv"), result.GetMatrix("C:\\DataSprint6\\InPutDataFileTask7V19.csv"));

        }
    }
}