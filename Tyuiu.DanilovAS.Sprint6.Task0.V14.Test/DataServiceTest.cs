using Tyuiu.DanilovAS.Sprint6.Task0.V14.Lib;
namespace Tyuiu.DanilovAS.Sprint6.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int x = 3;
            var wait = -0.444;
            var res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }
    }
}
