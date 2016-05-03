using System;
using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    class TestCalculator
    {
        [Test]
        public void Add_GivenNoNumber_ShouldReturnsZero()
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
        public void Add_GivenSingleNumber_ShouldReturnsNumber()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "1";
            var expected = 1;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenTwoNumber_ShouldReturnsSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "1,2";
            var expected = 3;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenMultipleNumber_ShouldReturnsSum()
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
        public void Add_GivenNewLinesBetweenNumbers_ShouldReturnsSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "1\n2,3";
            var expected = 6;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenDelimiteAtTheBeginningWithSeparateLine_ShouldReturnsSum()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "//;\n1;2";
            var expected = 3;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenNegativeNumbers_ShouldReturnsErrorMessages()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "-1,2,-3";
            var expected = "Negatives not allowed";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = Assert.Throws<ApplicationException>(()=> calculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result.Message);
        }

        [Test]
        public void Add_GivenNumberGreaterThanAThousand_ShouldReturnsExcessNumber()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var numbers = "1001,3";
            var expected = 3;
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
            var numbers = "//[***]\n1***2***3";
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
