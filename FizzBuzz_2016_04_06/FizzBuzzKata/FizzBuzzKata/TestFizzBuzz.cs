using System.Net;
using NUnit.Framework;

namespace FizzBuzzKata
{
    public class TestFizzBuzz
    {
        [TestCase("1")]
        [TestCase("2")]
        [TestCase("4")]
        public void IsFizzBuzz_GivenNumberNotDivisibleByThreeAndFive_ShouldReturnNumber(string input)
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);

            //---------------Test Result -----------------------
            Assert.AreEqual(input, result);
        }
        
        [TestCase("3")]
        [TestCase("6")]
        [TestCase("9")]
        public void IsFizzBuzz_GivenNumberIsDivisibleByThree_ShouldReturnFizz(string input)
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var expected = "Fizz";
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
