using Tyuiu.MarakovAD.Sprint1.Task3.V10.Lib;
namespace Tyuiu.MarakovAD.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 23.6;
            var res = ds.NumberToMoney(x);
            Assert.AreEqual("это " + 23 + "руб." + 0.6 + "коп.", res);
        }
    }
}
