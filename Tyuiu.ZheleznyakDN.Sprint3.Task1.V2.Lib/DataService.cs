using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task1.V2.Lib
{
    public class DataService : ISprint3Task1V2
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;
            while (i <= stopValue)
            {
                sum += Math.Sin(i) * 0.5;
                i++;
            }
            return Math.Round(sum, 3);
        }
    }
}
