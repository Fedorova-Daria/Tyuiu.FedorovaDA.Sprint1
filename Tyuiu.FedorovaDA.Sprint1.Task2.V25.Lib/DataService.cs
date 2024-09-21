using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FedorovaDA.Sprint1.Task2.V25.Lib
{
    public class DataService : ISprint1Task2V25
    {
        public double ConvertRadsToDegrees(int value)
        {
            return Math.Round(value * (180/3.14159274), 3);
        }
    }
}
