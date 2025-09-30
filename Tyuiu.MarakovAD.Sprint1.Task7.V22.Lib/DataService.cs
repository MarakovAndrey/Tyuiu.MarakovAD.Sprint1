using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MarakovAD.Sprint1.Task7.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {
            var res = (Math.Round(1 - Math.Pow(Math.Tan(1), 1 / Math.Tan(1)) + Math.Cos(1 - 2), 3));
            return res;
        }
    }
}
