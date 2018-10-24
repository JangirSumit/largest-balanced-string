using System;
using Largest_Balanced_String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace LargestBalancedStringTest
{
    [TestClass]
    public class LargestBalancedStringTest
    {
        IUnityContainer unityContainer = new UnityContainer();
        CalculateBalancedString calculateBalancedString = null;

        public LargestBalancedStringTest()
        {
            unityContainer.RegisterType<ICheckBalancedString, CheckBalancedString>();
            calculateBalancedString = unityContainer.Resolve<CalculateBalancedString>();
        }

        [TestMethod]
        public void TestCountBalancedStrings_Input1()
        {
            var actualData = calculateBalancedString.GetBalancedStringCount("(){}()[]");
            var expectedData = 8;

            Assert.AreEqual(expectedData, actualData);
        }

        [TestMethod]
        public void TestCountBalancedStrings_Input2()
        {
            var actualData = calculateBalancedString.GetBalancedStringCount("))[]]((");
            var expectedData = 6;

            Assert.AreEqual(expectedData, actualData);
        }

        [TestMethod]
        public void TestCountBalancedStrings_Input3()
        {
            var actualData = calculateBalancedString.GetBalancedStringCount("{{{{{{{}");
            var expectedData = 2;

            Assert.AreEqual(expectedData, actualData);
        }

        [TestMethod]
        public void TestCountBalancedStrings_Input4()
        {
            var actualData = calculateBalancedString.GetBalancedStringCount("[]{}]");
            var expectedData = 4;

            Assert.AreEqual(expectedData, actualData);
        }

        [TestMethod]
        public void TestCountBalancedStrings_Input5()
        {
            var actualData = calculateBalancedString.GetBalancedStringCount("{}}");
            var expectedData = 2;

            Assert.AreEqual(expectedData, actualData);
        }
    }
}
