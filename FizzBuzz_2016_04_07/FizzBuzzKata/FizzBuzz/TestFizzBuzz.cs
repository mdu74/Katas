
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [TestCase("1")]
        [TestCase("2")]
        [TestCase("4")]
        public void IsFizzBuzz_GivenNumberNoneDivisibleByThreeAndFive_ShouldReturnNumber(string input)
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var expected = input;
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
            var input = "6";
            var expected = "Fizz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenDivisibleByFive_ShouldReturnBuzz()
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
        public void IsFizzBuzz_GivenDivisibleByBoth_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "15";
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
