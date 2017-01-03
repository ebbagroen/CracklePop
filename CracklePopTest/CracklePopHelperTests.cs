using System;
using CracklePop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CracklePopTest
{
    [TestClass]
    public class CracklePopHelperTests
    {
        [TestMethod]
        public void GetNumberOrReplacement_30_ReturnCracklePop()
        {
           string result = CracklePopHelper.GetNumberOrReplacement(30);

           Assert.AreEqual("CracklePop", result);
        }

        [TestMethod]
        public void GetNumberOrReplacement_9_ReturnCrackle()
        {
            string result = CracklePopHelper.GetNumberOrReplacement(9);

            Assert.AreEqual("Crackle", result);
        }

        [TestMethod]
        public void GetNumberOrReplacement_10_ReturnPop()
        {
            string result = CracklePopHelper.GetNumberOrReplacement(10);

            Assert.AreEqual("Pop", result);
        }

        [TestMethod]
        public void GetNumberOrReplacement_Minus10_ReturnPop()
        {
            string result = CracklePopHelper.GetNumberOrReplacement(-10);

            Assert.AreEqual("Pop", result);
        }

        [TestMethod]
        public void GetNumberOrReplacement_7_Return7()
        {
            string result = CracklePopHelper.GetNumberOrReplacement(7);

            Assert.AreEqual("7", result);
        }

    }
}
