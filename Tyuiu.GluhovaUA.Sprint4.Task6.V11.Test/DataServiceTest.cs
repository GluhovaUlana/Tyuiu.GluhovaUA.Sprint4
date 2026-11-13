using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint4.Task6.V11.Lib;
namespace Tyuiu.GluhovaUA.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            var array = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };

            int res = ds.Calculate(array);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
