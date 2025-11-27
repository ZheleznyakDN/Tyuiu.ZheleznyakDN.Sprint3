using Tyuiu.ZheleznyakDN.Sprint3.Task5.V4.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(5, 1, 1, 3, 13);
            double wait = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 13; k++)
                {
                    wait += 5 / Math.Cos(k);
                }
            }
            wait = Math.Round(wait, 3);
            Assert.AreEqual(wait, result);
        }
    }
}
