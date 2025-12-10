using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DanilovAS.Sprint6.Task4.V2.Lib
{
    public class DataService : ISprint6Task4V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                y = (Math.Cos(i)) / (i - 0.7) - Math.Sin(i) * 12 * i + 2;
                y = Math.Round(y, 2);

                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
