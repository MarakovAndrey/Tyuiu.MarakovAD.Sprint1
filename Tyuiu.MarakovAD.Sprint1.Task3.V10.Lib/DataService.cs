using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MarakovAD.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            int wholeNumber = (int)number;
            double partNumber = number - wholeNumber;
            return "это " + wholeNumber + "руб. " + Math.Round(partNumber*100,2) + "коп.";
        }
    }
}
