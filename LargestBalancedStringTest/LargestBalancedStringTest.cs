using System;
using Largest_Balanced_String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LargestBalancedStringTest
{
    [TestClass]
    public class LargestBalancedStringTest
    {
        [TestMethod]
        public void TestCountBalancedStrings_Input1()
        {
            var actualData = new CheckBalancedString().CountBalancedStrings("(){}()[]");
            var expectedData = 8;

            Assert.AreEqual(expectedData, actualData);
        }

        [TestMethod]
        public void TestCountBalancedStrings_Input2()
        {
            var actualData = new CheckBalancedString().CountBalancedStrings("))[]]((");
            var expectedData = 6;

            Assert.AreEqual(expectedData, actualData);
        }

        [TestMethod]
        public void TestCountBalancedStrings_Input3()
        {
            var actualData = new CheckBalancedString().CountBalancedStrings("{{{{{{{}");
            var expectedData = 2;

            Assert.AreEqual(expectedData, actualData);
        }

        [TestMethod]
        public void TestCountBalancedStrings_Input4()
        {
            var actualData = new CheckBalancedString().CountBalancedStrings("[]{}]");
            var expectedData = 4;

            Assert.AreEqual(expectedData, actualData);
        }

        [TestMethod]
        public void TestCountBalancedStrings_Input5()
        {
            var actualData = new CheckBalancedString().CountBalancedStrings("{}}");
            var expectedData = 2;

            Assert.AreEqual(expectedData, actualData);
        }
    }
}
