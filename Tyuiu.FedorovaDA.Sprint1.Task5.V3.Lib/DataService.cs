using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FedorovaDA.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            if (k > 0)
            {
                int k1 = (int)(k * 0.001);
                k1 = (int)((k * 0.001 - k1) * 1000);
                int h = (int)(k1 * 0.01);
                return h;
            }
            else
            {
                Console.WriteLine("В записи присутсвует отрицательное целое число! Ошибка!");
                return 0;
            }
        }
    }
}
