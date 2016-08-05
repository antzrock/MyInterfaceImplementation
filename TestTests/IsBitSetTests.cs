using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace TestTests
{
    [TestClass]
    public class IsBitSetTests
    {
        private readonly IMyInterface _myInterface = new MyInterface();

        [TestInitialize]
        public void Startup()
        {

        }

        [TestCleanup]
        public void Cleanup()
        {

        }

        [TestMethod]
        [TestCategory("IsBitSet")]
        public void IsBitSet_True_1()
        {
            int value = 9;
            int bit = 0;

            bool bitIsSet = _myInterface.IsBitSet(value, bit);

            Assert.AreEqual(bitIsSet, true);
        }

        [TestMethod]
        [TestCategory("IsBitSet")]
        public void IsBitSet_False_1()
        {
            int value = 9;
            int bit = 1;

            bool bitIsSet = _myInterface.IsBitSet(value, bit);

            Assert.AreEqual(bitIsSet, false);
        }

        [TestMethod]
        [TestCategory("IsBitSet")]
        public void IsBitSet_False_2()
        {
            int value = 9;
            int bit = 2;

            bool bitIsSet = _myInterface.IsBitSet(value, bit);

            Assert.AreEqual(bitIsSet, false);
        }

        [TestMethod]
        [TestCategory("IsBitSet")]
        public void IsBitSet_True_2()
        {
            int value = 9;
            int bit = 3;

            bool bitIsSet = _myInterface.IsBitSet(value, bit);

            Assert.AreEqual(bitIsSet, true);
        }

        [TestMethod]
        [TestCategory("IsBitSet")]
        public void IsBitSet_False_Bit_Parameter_Is_Negative()
        {
            int value = 9;
            int bit = -5;

            bool bitIsSet = _myInterface.IsBitSet(value, bit);

            Assert.AreEqual(bitIsSet, false);
        }

        [TestMethod]
        [TestCategory("IsBitSet")]
        public void IsBitSet_False_Bit_Parameter_Is_Beyond_Array_Bounds()
        {
            int value = 9;
            int bit = 50;

            bool bitIsSet = _myInterface.IsBitSet(value, bit);

            Assert.AreEqual(bitIsSet, false);
        }
    }
}
