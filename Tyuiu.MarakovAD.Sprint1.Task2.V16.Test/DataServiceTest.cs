using Tyuiu.MarakovAD.Sprint1.Task2.V16.Lib;
namespace Tyuiu.MarakovAD.Sprint1.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExprassion()
        {
            DataService ds = new DataService();
            int x = 4;
            var res = ds.CalculatePerimetrCircle(x);
            Assert.AreEqual(25.133, res);
        }
    }
}
