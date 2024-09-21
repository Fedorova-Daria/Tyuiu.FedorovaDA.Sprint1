using Tyuiu.FedorovaDA.Sprint1.Task3.V15.Lib;


namespace Tyuiu.FedorovaDA.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Федрова Д. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Федорова Дарья Артемовна | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, решающую следующую задачу:                          *");
            Console.WriteLine("* два автомобиля имеют скорости V1 км/ч и V2 км/ч соответственно,         *");
            Console.WriteLine("* находятся на расстоянии S км друг от друга и движутся в противоположные *");
            Console.WriteLine("* стороны. Определить расстояние между ними через T часов.                *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1;
            Console.WriteLine("Введите скорость первого автомобиля:");
            v1 = Convert.ToInt32(Console.ReadLine());

            double v2;
            Console.WriteLine("Введите скорость второго автомобиля:");
            v2 = Convert.ToInt32(Console.ReadLine());
            double S;
            Console.WriteLine("Введите расстояние автомобилей, находящихся друг от друга:");
            S = Convert.ToInt32(Console.ReadLine());
            double T;
            Console.WriteLine("Введите время:");
            T = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между автомобилями:" + ds.DistanceOverTime(v1,v2,S,T));
        }
    }
}
