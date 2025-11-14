using System.ComponentModel.Design;
using Tyuiu.DanilovAS.Sprint6.Task2.V25.Lib;
namespace Tyuiu.DanilovAS.Sprint6.Task2.V25.Test
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
            int len = (stopValue - startValue) + 1;

            double[]waitArray = new double[len];
            waitArray[0] = 23.612;
            waitArray[1]= 16.077;
            waitArray[2]= 7.838;
            waitArray[3] = 4.578;
            waitArray[4] = 2.88;
            waitArray[5] = 0.75;
            waitArray[6] = -4.474;
            waitArray[7] = -9.461;
            waitArray[8] = -7.414;
            waitArray[9] = -6.162;
            waitArray[10] = -7.294 ;

            double[] resultArray = new double[len];
            resultArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(waitArray, resultArray);
        }
    }
}
