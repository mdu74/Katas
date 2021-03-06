﻿using System;
using NUnit.Framework;

namespace StringCalculatorKata
{
    [TestFixture]
    class TestCalculator
    {
        [Test]
        public void Add_GivenEmptry_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 0;
            var numbers = "";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenSingleNumber_ShouldReturnNumber()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 1;
            var numbers = "1";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenTwoNumbers_ShouldReturnsSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 3;
            var numbers = "1,2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenMultipleNumbers_ShouldReturnsSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 6;
            var numbers = "1,2,3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenNewLineBetweenNumbers_ShouldReturnsSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 6;
            var numbers = "1\n2,3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenDelimiterOfSeparateLine_ShouldReturnsSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 3;
            var numbers = "//;\n1;2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenNegativeNumber_ShouldReturnErrorMessage()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = "Negatives not allowed";
            var numbers = "-1,2,-3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = Assert.Throws<ApplicationException>(() => calculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result.Message);
        }

        [Test]
        public void Added_GivenNumbersGreaterThanAThousand_ShouldIgnoreExcess()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 2;
            var numbers = "1001,2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenDelimiterOfAnyLength_ShouldReturnsSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 6;
            var numbers = "//[***]\n1***2***3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenMultipleDelimiter_ShouldReturnsSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 6;
            var numbers = "//[*][%]\n1*2%3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        private static Calculator CreateCalculator()
        {
            return new Calculator();
        }
    }
}
