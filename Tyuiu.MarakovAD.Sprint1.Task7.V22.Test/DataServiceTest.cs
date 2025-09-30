using Tyuiu.MarakovAD.Sprint1.Task7.V22.Lib;
namespace Tyuiu.MarakovAD.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.211, res);
        }
    }
}
