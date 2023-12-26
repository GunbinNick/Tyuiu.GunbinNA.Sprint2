using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint2.Task4.V15.Lib;
namespace Tyuiu.GunbinNA.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 4, y = 2;
            double wait = 150.062;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
