using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FedorovaDA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {

           
            

            string[] words = value.Split(' ');
            string a = " ";

            foreach (string str in words)
            {
                if (str.Contains("нн"))
                    a = a.Insert(a.Length - 1,' ' + str);
                    

            }
            return a.Trim();

        }
    }
}
