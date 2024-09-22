using Tyuiu.FedorovaDA.Sprint1.Task7.V13.Lib;

namespace Tyuiu.FedorovaDA.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            double x = 6;
            double y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.541 , res);
        }
    }
}