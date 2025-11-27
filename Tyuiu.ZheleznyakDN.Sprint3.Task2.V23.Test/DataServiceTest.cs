using Tyuiu.ZheleznyakDN.Sprint3.Task2.V23.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double result = ds.GetSumSeries(1.5, 1, 13);
            double wait = 0;
            int k = 1;
            do
            {
                wait += (Math.Pow(1.5, k) + 0.25) * Math.Sin(k);
                k++;
            }
            while (k <= 13);
            wait = Math.Round(wait, 3);
            Assert.AreEqual(wait, result);
        }
    }
}
