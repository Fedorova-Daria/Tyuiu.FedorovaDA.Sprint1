using Tyuiu.FedorovaDA.Sprint1.Task2.V25.Lib;

namespace Tyuiu.FedorovaDA.Sprint1.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()
        {
            DataService ds = new DataService();
            int x =  2;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(114.59155587429834, res);
        }
    }
}