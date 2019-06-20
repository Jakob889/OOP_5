using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UMLtoC;

namespace UnitTest_UMLtoC
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void CreateSum_TwoPlusTwoPointOne_IsFour()
        {
            var master = new Master();
            master.AddNumber(new Number(2));
            master.AddNumber(new Number(2.1));
            var canCreateSumTwoPlusTwoPointOne = master;
            Assert.IsTrue(canCreateSumTwoPlusTwoPointOne.CreateSum() == 4);
        }

        [TestMethod]
        public void CreateSum_Empty_IsZero()
        {
            Assert.IsTrue((new Master()).CreateSum() == 0);
        }

        [TestMethod]
        public void CreateSum_TwoPlusMinusSix_IsMinusFour()
        {
            var master2 = new Master();
            master2.AddNumber(new Number(2));
            master2.AddNumber(new Number(-6));
            var canCreateSumTwoPlusMinusSix = master2;
            Assert.IsTrue(canCreateSumTwoPlusMinusSix.CreateSum() == -4);
        }
    }
}
