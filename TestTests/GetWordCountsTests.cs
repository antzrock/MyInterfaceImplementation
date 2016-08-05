using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Test;

namespace TestTests
{
    [TestClass]
    public class GetWordCountsTests
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
        [TestCategory("GetWordCountsString")]
        public void GetWordCounts_Non_Empty_String_Parameter_Correct_Results_1()
        {
            string words = "one,two, two, three, three, three, three,Four,four, four, four, four, five, five, five, five, five";

            var result = _myInterface.GetWordCounts(words);

            var expectedList = new List<Tuple<string, int>>
            {
                Tuple.Create("one", 1),
                Tuple.Create("two", 2),
                Tuple.Create("three", 4),
                Tuple.Create("Four", 1),
                Tuple.Create("four", 4),
                Tuple.Create("five", 5)
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetWordCountsString")]
        public void GetWordCounts_Non_Empty_String_Parameter_Correct_Results_Case_Sensitive()
        {
            string words = "one,two, two, three, three, three, three,Four,four";

            var result = _myInterface.GetWordCounts(words);

            var expectedList = new List<Tuple<string, int>>
            {
                Tuple.Create("one", 1),
                Tuple.Create("two", 2),
                Tuple.Create("three", 4),
                Tuple.Create("Four", 1),
                Tuple.Create("four", 1)
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetWordCountsString")]
        public void GetWordCounts_Null_String_Parameter()
        {
            string words = null;

            var result = _myInterface.GetWordCounts(words);

            var expectedList = new List<Tuple<string, int>>
            {

            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetWordCountsString")]
        public void GetWordCounts_Empty_String_Parameter()
        {
            string words = "";

            var result = _myInterface.GetWordCounts(words);

            var expectedList = new List<Tuple<string, int>>
            {
               
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetWordCountsArray")]
        public void GetWordCounts_Non_Empty_Array_Parameter_Correct_Results_Case_Sensitive()
        {
            string[] words = new string[] { "one", "two", "two", "three", "tHreE", "Three", "three", "Four", "four" };

            var result = _myInterface.GetWordCounts(words);

            var expectedList = new List<Tuple<string, int>>
            {
                Tuple.Create("one", 1),
                Tuple.Create("two", 2),
                Tuple.Create("three", 2),
                Tuple.Create("tHreE", 1),
                Tuple.Create("Three", 1),
                Tuple.Create("Four", 1),
                Tuple.Create("four", 1)
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetWordCountsArray")]
        public void GetWordCounts_Non_Empty_Array_Parameter_Correct_Results_2()
        {
            string[] words = new string[] { "mustaine", "hetfield", "joesatriani", "joesatriani", "joesatriani", "stevevai", "mustaine" };

            var result = _myInterface.GetWordCounts(words);

            var expectedList = new List<Tuple<string, int>>
            {
                Tuple.Create("mustaine", 2),
                Tuple.Create("hetfield", 1),
                Tuple.Create("joesatriani", 3),
                Tuple.Create("stevevai", 1)
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetWordCountsArray")]
        public void GetWordCounts_Non_Empty_Array_Parameter_Correct_Results_1()
        {
            string[] words = new string[] { "one", "two", "two", "three", "three", "three", "four" };

            var result = _myInterface.GetWordCounts(words);

            var expectedList = new List<Tuple<string, int>>
            {
                Tuple.Create("one", 1),
                Tuple.Create("two", 2),
                Tuple.Create("three", 3),
                Tuple.Create("four", 1)
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetWordCountsArray")]
        public void GetWordCounts_Empty_Array_Parameter()
        {
            string[] words = new string[] { };

            var result = _myInterface.GetWordCounts(words);

            var expectedList = new List<Tuple<string, int>>
            {
                
            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }

        [TestMethod]
        [TestCategory("GetWordCountsArray")]
        public void GetWordCounts_Null_Array_Parameter()
        {
            string[] words = null;

            var result = _myInterface.GetWordCounts(words);

            var expectedList = new List<Tuple<string, int>>
            {

            };

            bool isTrue = result.SequenceEqual(expectedList);

            Assert.AreEqual(isTrue, true);
        }
    }
}
