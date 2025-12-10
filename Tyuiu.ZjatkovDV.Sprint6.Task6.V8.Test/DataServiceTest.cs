using Tyuiu.ZjatkovDV.Sprint6.Task6.V8.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task6.V8.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCollectTextFromFile()
        {
            var result = new DataService();
            Assert.Equal(result.CollectTextFromFile("C:\\DataSprint6\\InPutDataFileTask6V8.csv"), result.CollectTextFromFile("C:\\DataSprint6\\InPutDataFileTask6V8.csv"));
        }
    }
}