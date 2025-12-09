using Tyuiu.ZjatkovDV.Sprint6.Task5.V14.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task5.V14.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckLoadFromDataFile()
        {
            var result = new DataService();
            Assert.Equal(result.LoadFromDataFile("C:\\DataSprint6\\InPutFileTask5V14.txt"), result.LoadFromDataFile("C:\\DataSprint6\\InPutFileTask5V14.txt"));
        }
    }
}