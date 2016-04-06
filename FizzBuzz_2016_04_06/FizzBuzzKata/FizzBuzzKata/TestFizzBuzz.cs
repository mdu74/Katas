using System.Net;
using NUnit.Framework;

namespace FizzBuzzKata
{
    public class TestFizzBuzz
    {
        [Test]
        public void IsFizzBuzz_GivenOne_ShouldReturnOne()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "1";
            var expected = "1";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);

            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenTwo_ShouldReturnTwo()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "2";
            var expected = "2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenThree_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "3";
            var expected = "Fizz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenFour_ShouldReturnFour()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "4";
            var expected = "4";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenFive_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "5";
            var expected = "Buzz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenDivisibleByThree_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "9";
            var expected = "Fizz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenDivisibleByFive_ShouldBuzz()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "10";
            var expected = "Buzz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenIsDivisibleByBothThreeAndFive_ShouldFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "30";
            var expected = "FizzBuzz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        private static FizzBuzz CreateFizzBuzz()
        {
            return new FizzBuzz();
        }

    }
}
