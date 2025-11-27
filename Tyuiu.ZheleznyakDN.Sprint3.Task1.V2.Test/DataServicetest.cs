using Tyuiu.ZheleznyakDN.Sprint3.Task1.V2.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServicetest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double result = ds.GetSumSeries(1, 15);
            double wait = 0;
            int i = 1;
            while (i <= 15)
            {
                wait += Math.Sin(i) * 0.5;
                i++;
            }
            wait = Math.Round(wait, 3);
            Assert.AreEqual(wait, result);
        }
    }
}
