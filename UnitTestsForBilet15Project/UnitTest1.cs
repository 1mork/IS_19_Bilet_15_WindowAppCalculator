using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IS_19_Bilet_15_WindowAppCalculator;


namespace UnitTestsForBilet15Project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string exp = "Услуга не найдена";
            string res = IS_19_Bilet_15_WindowAppCalculator.Form1.testmethodOne(1);

            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string exp = "Услуга не найдена";
            string res = IS_19_Bilet_15_WindowAppCalculator.Form1.testmethodTwo(22222222,11111111);

            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string exp = "Услуга не найдена";
            string res = IS_19_Bilet_15_WindowAppCalculator.Form1.testmethodThree(-1);

            Assert.AreEqual(exp, res);
        }


    }
}
