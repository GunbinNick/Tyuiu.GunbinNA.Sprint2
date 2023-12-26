﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint2.Task7.V1.Lib;
namespace Tyuiu.GunbinNA.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.1, y = 0.5;
            bool wait = true;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
