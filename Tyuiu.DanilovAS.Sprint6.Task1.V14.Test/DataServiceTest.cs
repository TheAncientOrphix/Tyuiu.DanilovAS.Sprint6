using Microsoft.ApplicationInsights.Metrics.Extensibility;
using Tyuiu.DanilovAS.Sprint6.Task1.V14.Lib;
namespace Tyuiu.DanilovAS.Sprint6.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue)+1;

            double[] waitArray = new double[len];
            waitArray[0] = -2.152;
            waitArray[1] = -2.570;
            waitArray[2] = -3;
            waitArray[3] = -3.828;
            waitArray[4] = -11.701;
            waitArray[5] = 3.000;
            waitArray[6] = 2.194;
            waitArray[7] = 3.314;
            waitArray[8] = 2.97;
            waitArray[9] = 1.184;
            waitArray[10] = 0.028;

            double[] resultArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(waitArray, resultArray);
        }
    }
}
