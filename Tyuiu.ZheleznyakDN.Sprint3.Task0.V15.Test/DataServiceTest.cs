using Tyuiu.ZheleznyakDN.Sprint3.Task0.V15.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double t = 0.7;
            int startK = 1;
            int stopK = 10;
            double result = ds.GetSumSeries(t, startK, stopK);

            Assert.IsFalse(double.IsNaN(result));
            Assert.IsFalse(double.IsInfinity(result));
        }
    }
}
