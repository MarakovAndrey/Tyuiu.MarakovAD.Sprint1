using Tyuiu.MarakovAD.Sprint1.Task5.V5.Lib;
namespace Tyuiu.MarakovAD.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 32.597;

            Assert.AreEqual(ds.Calculate(x), 5);
        }
    }
}
