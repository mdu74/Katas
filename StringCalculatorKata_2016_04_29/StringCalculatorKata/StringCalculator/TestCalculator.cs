using System;
using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    class TestCalculator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturnZero()
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
        public void Add_GivenTwoNumbers_ShouldReturnSum()
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
        public void Add_GivenMultipleNumbers_ShouldReturnSum()
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
        public void Add_GivenNewLinesBetweenNumbers_ShouldReturnSum()
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
        public void Add_GivenBeginningWithSeparateLineDelimiter_ShouldReturnSum()
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
        public void Add_GivenNegativeNumbers_ShouldReturnErrorMessage()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = "Negatives not allowed";
            var numbers = "-1,2,-3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = Assert.Throws<Exception>(()=> calculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result.Message);
        }

        [Test]
        public void Add_GivenGreaterThanAThousand_ShouldIgnore()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 3;
            var numbers = "1001,3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenAnyLengthOfDelimiter_ShouldReturnSum()
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
        public void Add_GivenMultipleDelimiters_ShouldReturnSum()
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
