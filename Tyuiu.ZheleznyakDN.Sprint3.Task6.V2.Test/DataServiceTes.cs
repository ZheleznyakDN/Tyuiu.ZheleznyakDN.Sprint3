using Tyuiu.ZheleznyakDN.Sprint3.Task6.V2.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTes
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(12, 18);

            int wait = 0;
            for (int num = 12; num <= 18; num++)
            {
                for (int divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        wait++;
                    }
                }
            }

            Assert.AreEqual(wait, result);
        }
    }
}
