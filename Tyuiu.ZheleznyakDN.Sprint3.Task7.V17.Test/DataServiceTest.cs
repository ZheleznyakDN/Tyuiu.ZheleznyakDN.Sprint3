using Tyuiu.ZheleznyakDN.Sprint3.Task7.V17.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);
            double[] wait = new double[11];

            for (int x = -5, i = 0; x <= 5; x++, i++)
            {
                if (x + 1.7 == 0)
                {
                    wait[i] = 0;
                }
                else
                {
                    double value = Math.Sin(x) / (x + 1.7) - Math.Cos(x) * 4 * x - 6;
                    wait[i] = Math.Round(value, 2);
                }
            }

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
