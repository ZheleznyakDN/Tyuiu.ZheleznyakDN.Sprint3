using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task7.V17.Lib
{
    public class DataService : ISprint3Task7V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {
                if (x == 0)
                {
                    result[i] = 0;
                }
                else
                {
                    double value = ((x + Math.Pow(x, 2)) / x) - Math.Cos(x) * 4 * x - 6;
                    result[i] = Math.Round(value, 2);
                }
            }
            return result;
        }
    }
}
