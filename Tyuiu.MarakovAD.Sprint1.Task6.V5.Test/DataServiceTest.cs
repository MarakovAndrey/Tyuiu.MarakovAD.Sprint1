using Tyuiu.MarakovAD.Sprint1.Task6.V5.Lib;
namespace Tyuiu.MarakovAD.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string x = "Пьющий водку казак";
            DataService ds = new DataService();
            var res = ds.CheckSymmetricalWords(x);
            Assert.AreEqual("казак", res);
        }
    }
}
