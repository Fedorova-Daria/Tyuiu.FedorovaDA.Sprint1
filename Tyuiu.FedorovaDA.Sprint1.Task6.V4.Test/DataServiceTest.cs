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
            string words = "�������� �������� ������������ ������ ����� ������� ������� ��������";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(words);
            Assert.AreEqual("�������� �������� ������������", res );
        }
    }
}