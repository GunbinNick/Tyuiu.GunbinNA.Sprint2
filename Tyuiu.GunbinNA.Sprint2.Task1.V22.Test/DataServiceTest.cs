using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint2.Task1.V22.Lib;

namespace Tyuiu.GunbinNA.Sprint2.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] result = new bool[6];
            result = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, false, false };
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
