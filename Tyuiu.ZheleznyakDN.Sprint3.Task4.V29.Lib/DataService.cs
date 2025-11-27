using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task4.V29.Lib
{
    public class DataService : ISprint3Task4V29
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;
                sum += Math.Cos(x) / x;
            }
            return Math.Round(sum, 3);
        }
    }
}
