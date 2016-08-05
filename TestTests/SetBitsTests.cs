using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace TestTests
{
    [TestClass]
    public class SetBitsTests
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
        [TestCategory("SetBits")]
        public void SetBits_Correct_1()
        {
            int value = 9;
            int[] bitsToSet = new int[] { 2 };

            int newValue = _myInterface.SetBits(value, bitsToSet);

            Assert.AreEqual(newValue, 13);
        }

        [TestMethod]
        [TestCategory("SetBits")]
        public void SetBits_Correct_2()
        {
            int value = 50;
            int[] bitsToSet = new int[] { 3, 6 };

            int newValue = _myInterface.SetBits(value, bitsToSet);

            Assert.AreEqual(newValue, 59);
        }

        [TestMethod]
        [TestCategory("SetBits")]
        public void SetBits_Index_Out_Of_Range_Positive()
        {
            int value = 50;
            int[] bitsToSet = new int[] { 7 };

            int newValue = _myInterface.SetBits(value, bitsToSet);

            Assert.AreEqual(newValue, 50);
        }

        [TestMethod]
        [TestCategory("SetBits")]
        public void SetBits_Index_Out_Of_Range_Negative()
        {
            int value = 50;
            int[] bitsToSet = new int[] { -15 };

            int newValue = _myInterface.SetBits(value, bitsToSet);

            Assert.AreEqual(newValue, 50);
        }
    }
}
