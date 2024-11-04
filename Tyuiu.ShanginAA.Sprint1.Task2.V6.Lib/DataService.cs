using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShanginAA.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            double result = (double)value / 1000;
            return result;
        }
    }
}
