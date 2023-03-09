using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp9;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void EmptyString_RetZero()
        {
            var result = Calculator.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void OneNumber_RetNumber()
        {
            var result = Calculator.Add("30");
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TwoNumbers_RetNumber()
        {
            var result = Calculator.Add("30,721");
            Assert.AreEqual(751, result);
        }
        [TestMethod]
        public void MultipleNumbers1_RetNumber()
        {
            var result = Calculator.Add("1,2,3,4");
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void MultipleNumbers2_RetNumber()
        {
            var result = Calculator.Add("51 ,23,56     ,1,1,1   ,  1");
            Assert.AreEqual(134, result);
        }

        [TestMethod]
        public void NewLineSeparator_RetNumber()
        {
            var result = Calculator.Add("51" + '\n' + "2");

            Assert.AreEqual(53, result);
        }

        [TestMethod]
        public void MixedSeparators_RetNumber()
        {
            var result = Calculator.Add("51" + '\n' + "2,4,6\n3");

            Assert.AreEqual(66, result);
        }

    }
}