using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint4.Task1.V5.Lib;
namespace Tyuiu.GluhovaUA.Sprint4.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate1()
        {
            DataService ds = new DataService();
            int[] numsarray = { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7 };
            int res = ds.Calculate(numsarray);
            int wait = 60;
            Assert.AreEqual(wait, res);
        }
    }
}
