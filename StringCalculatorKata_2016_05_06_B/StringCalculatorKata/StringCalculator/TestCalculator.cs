using System;
using NUnit.Framework;

namespace StringCalculator
{
    class TestCalculator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expect = 0;
            var numbers = "";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Add_GivenSingleNumber_ShouldReturnNumber()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expect = 1;
            var numbers = "1";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Add_GivenTwoNumbers_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expect = 3;
            var numbers = "1,2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Add_GivenMultipleNumbers_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expect = 6;
            var numbers = "1,2,3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Add_GivenNewLinesBetweenNumbers_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expect = 6;
            var numbers = "1\n2,3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Add_GivenStartsWithSeparateLineDelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expect = 3;
            var numbers = "//;\n1;2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Add_GivenNegativeNumbers_ShouldReturnErrorMessage()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expect = "Negatives not allowed";
            var numbers = "-1,2,-3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = Assert.Throws<Exception>(()=> calculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result.Message);
        }

        [Test]
        public void Add_GivenGreaterThanAThousand_ShouldIgnore()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expect = 2;
            var numbers = "1001,2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Add_GivenAnyLengthDelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expect = 6;
            var numbers = "//[***]\n1***2***3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Add_GivenMultipleDelimiters_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expect = 6;
            var numbers = "//[*][%]\n1*2%3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        private static Calculator CreateCalculator()
        {
            return new Calculator();
        }
    }
}
