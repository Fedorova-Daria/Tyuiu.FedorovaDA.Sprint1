using Tyuiu.FedorovaDA.Sprint1.Task5.V3.Lib;


namespace Tyuiu.FedorovaDA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 130985;
            int h = 9;
            var res = ds.Calculate(k);
            Assert.AreEqual(h, res);
        }
    }
}