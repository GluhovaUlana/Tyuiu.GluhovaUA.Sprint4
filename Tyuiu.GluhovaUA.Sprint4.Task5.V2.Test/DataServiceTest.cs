using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint4.Task5.V2.Lib;
namespace Tyuiu.GluhovaUA.Sprint4.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 3, 4, 3, 4, 1 },
                                          { 3, -6, 4, 3, 2 },
                                          { 5, 1, -7, 1, 3 },
                                          { 1, -5, 2, 1, 2 },
                                          { 2, 2, 2, 2, -4 } };

            int res = ds.Calculate(matrix);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}

