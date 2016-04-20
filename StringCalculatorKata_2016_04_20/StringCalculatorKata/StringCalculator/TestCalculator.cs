using System;
using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    class TestCalculator
    {
        [Test]
        public void Add_EmptyString_ShouldReturnZero()
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
            var expected = 4;
            var numbers = "4";
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
        public void Add_GivenMultipleNumbers_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "1,2,3";
            var expected = 6;
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
        public void Add_GivenSeperateLine_ShouldReturnsSum()
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
        public void Add_GivenNegativeNumbers_ShouldReturnsException()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = "Negatives Not Allowed";
            var numbers = "-1,2,-3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = Assert.Throws<ApplicationException>(() => calculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result.Message);
        }

        [Test]
        public void Add_GivenNumbersGreaterThanAThousand_ShouldBeIgnored()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "1001,2";
            var expected = 2;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenDelimiterOfAnyLength_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "//[***]\n1***2***3";
            var expected = 6;
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
            var numbers = "//[*][%]\n1*2%3";
            var expected = 6;
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
