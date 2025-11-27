using Tyuiu.ZheleznyakDN.Sprint3.Task4.V29.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(-5, 5);
            double wait = 0;
            for (int x = -5; x <= 5; x++)
            {
                if (x == 0) continue;
                wait += Math.Cos(x) / x;
            }
            wait = Math.Round(wait, 3);
            Assert.AreEqual(wait, result);
        }
    }
}
