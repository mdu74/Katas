using System;
using NUnit.Framework;

namespace StringCalculator
{
    class TestCalculator
    {
        [Test]
        public void Add_GivenEmpty_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "";
            var expect = 0;
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
            var numbers = "1";
            var expect = 1;
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
            var numbers = "1,2";
            var expect = 3;
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
            var numbers = "1,2,3";
            var expect = 6;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Add_GivenNewLineBetweenNumbers_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "1\n2,3";
            var expect = 6;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Add_GivenStartWithSeparateLineDelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "//;\n1;2";
            var expect = 3;
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
            var numbers = "-1,2,-3";
            var expect = "Negatives not allowed";
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
            var numbers = "1001,2";
            var expect = 2;
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
            var numbers = "//[***]\n1***2***3";
            var expect = 6;
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
            var numbers = "//[*][%]\n1*2%3";
            var expect = 6;
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
