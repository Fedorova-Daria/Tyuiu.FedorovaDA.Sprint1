using System;
using Tyuiu.FedorovaDA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.FedorovaDA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string words = "семенной туманный безветренный стекло ягоды кованый жеваный ветреный";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(words);
            Assert.AreEqual("семенной туманный безветренный", res );
        }
    }
}