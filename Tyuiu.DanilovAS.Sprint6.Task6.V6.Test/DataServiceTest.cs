using Tyuiu.DanilovAS.Sprint6.Task6.V6.Lib;
namespace Tyuiu.DanilovAS.Sprint6.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V6.txt";

            string wait = "YebQ HbJcPW";
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual(wait, result);
        }
    }
}
