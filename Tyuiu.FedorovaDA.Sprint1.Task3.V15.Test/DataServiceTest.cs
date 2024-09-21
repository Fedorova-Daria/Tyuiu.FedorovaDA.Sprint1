using Tyuiu.FedorovaDA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.FedorovaDA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 2;
            double v2 = 3;
            double S = 3;
            double T = 3;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(18, res);
        }
    }
}