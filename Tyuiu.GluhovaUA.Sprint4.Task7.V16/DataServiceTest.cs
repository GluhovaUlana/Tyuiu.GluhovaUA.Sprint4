using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint4.Task7.V16.Lib;

namespace Tyuiu.GluhovaUA.Sprint4.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "382976421897948";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 768;
            Assert.AreEqual(wait, res);
        }
    }
}