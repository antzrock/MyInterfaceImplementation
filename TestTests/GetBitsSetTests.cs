using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using System.Collections.Generic;
using System.Linq;

namespace TestTests
{
    [TestClass]
    public class GetBitsSetTests
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
        [TestCategory("GetBitsSet")]
        public void GetBitSet_Parameter_Is_Negative()
        {
            int value = -50;
            string bitString = Convert.ToString(value, 2);

            var result = _myInterface.GetBitsSet(value);

            var expectedList = new List<int>
            {
                0,
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15,
                16,
                17,
                18,
                19,
                20,
                21,
                22,
                23,
                24,
                25,
                28,
                29,
                30

            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetBitsSet")]
        public void GetBitSet_Parameter_Is_Zero()
        {
            int value = 0;

            var result = _myInterface.GetBitsSet(value);

            var expectedList = new List<int>
            {
               
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetBitsSet")]
        public void GetBitsSet_Correct_1()
        {
            int value = 9;

            var result = _myInterface.GetBitsSet(value);

            var expectedList = new List<int>
            {
                0,
                3
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetBitsSet")]
        public void GetBitsSet_Parameter_From_SetBits_Method()
        {
            int value = _myInterface.SetBits(9, new[] { 2 });

            var result = _myInterface.GetBitsSet(value);

            var expectedList = new List<int>
            {
                0,
                1,
                3
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetBitsSet")]
        public void GetBitsSet_Correct_2()
        {
            int value = 13;

            var result = _myInterface.GetBitsSet(value);

            var expectedList = new List<int>
            {
                0,
                1,
                3
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetBitsSet")]
        public void GetBitsSet_Correct_3()
        {
            int value = 50;
            
            var result = _myInterface.GetBitsSet(value);

            var expectedList = new List<int>
            {
                0,
                1,
                4
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetBitsSet")]
        public void GetBitsSet_Correct_4()
        {
            int value = 42;

            string bitString = Convert.ToString(value, 2);

            var result = _myInterface.GetBitsSet(value);

            var expectedList = new List<int>
            {
                0,
                2,
                4
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

    }
}
