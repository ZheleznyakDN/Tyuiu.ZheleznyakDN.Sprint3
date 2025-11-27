using Tyuiu.ZheleznyakDN.Sprint3.Task3.V24.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string result = ds.ReplaceCharInString("gft hggt ntg", 'g', '*');
            string wait = "*ft h**t nt*";
            Assert.AreEqual(wait, result);
        }
    }
}
