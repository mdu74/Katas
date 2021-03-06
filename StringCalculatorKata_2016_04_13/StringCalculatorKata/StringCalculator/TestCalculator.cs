﻿using System;
using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    class TestCalculator
    {
        [Test]
        public void Add_GivenNoNumbers_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "";
            var expected = 0;
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
            var expected = 2;
            var numbers = "2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenTwoNumber_ShouldReturnSumOfNumbers()
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
        public void Add_GivenMultipleNumbers_ShouldReturnSumOfNumbers()
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
        public void Add_GivenNewLineBetweenNumbers_ShouldReturnSumOfNumbers()
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
        public void Add_GivenSeparateLineInTheBeginning_ShouldReturnSumOfNumbers()
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
        public void Add_GivenNegativeNumber_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = "negative not allowed";
            var numbers = "-1, 2, 3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = Assert.Throws<ApplicationException>(()=>calculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result.Message);
        }

        [Test]
        public void Add_GivenSumIsBiggerThanAThousand_ShouldIgnore()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "3,1001";
            var expected = 3;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Ignore]
        [Test]
        public void Add_GivenAnyLengthOfDelimiter_ShouldReturnSumOfNumbers()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "//[***]\n1***2***3";
            var expected = 6;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result =calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        private static Calculator CreateCalculator()
        {
            return new Calculator();
        }
    }
}
