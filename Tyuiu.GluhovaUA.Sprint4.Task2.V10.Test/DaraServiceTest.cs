using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint4.Task2.V10.Lib;
namespace Tyuiu.GluhovaUA.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13 };
            int res = ds.Calculate(array);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}