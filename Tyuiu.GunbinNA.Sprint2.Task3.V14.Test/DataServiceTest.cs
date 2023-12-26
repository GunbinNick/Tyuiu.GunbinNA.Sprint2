using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint2.Task3.V14.Lib;
namespace Tyuiu.GunbinNA.Sprint2.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0;
            double wait = 0.75;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
