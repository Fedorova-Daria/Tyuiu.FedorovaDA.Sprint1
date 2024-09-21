using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FedorovaDA.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V17
    {
        public double Calculate(double x, double y)
        {
            if (x > 5 * y)
            {
                var res = 1 / (Math.Sqrt(x - 5 * y));
                return Math.Round(res, 3);
            }
            else
            {
                Console.WriteLine("Знак в корне отрицательный! Ошибка!");
                return 0;

            }
        }
    }
}
