using Tyuiu.MarakovAD.Sprint1.Task4.V30.Lib;
namespace Tyuiu.MarakovAD.Sprint1.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(1, 2);
            Assert.AreEqual(12.53, res);
        }
    }
}
