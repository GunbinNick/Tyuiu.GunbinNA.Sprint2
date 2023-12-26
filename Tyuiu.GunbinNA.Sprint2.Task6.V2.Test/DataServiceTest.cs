using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint2.Task6.V2.Lib;
namespace Tyuiu.GunbinNA.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int m = 12;
            string wait = "Зима";
            var res = ds.FindMonthSeason(m);
            Assert.AreEqual(wait, res);
        }
    }
}
