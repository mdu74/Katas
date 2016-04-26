using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class TestFizzBuzz
    {
        [TestCase("1")]
        [TestCase("2")]
        [TestCase("4")]
        public void IsFizzBuzz_GivenOne_ShouldReturnOne(string input)
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

        [TestCase("3")]
        [TestCase("6")]
        [TestCase("9")]
        public void IsFizzBuzz_GivenThree_ShouldReturnFizz(string input)
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

        [TestCase("5")]
        [TestCase("10")]
        [TestCase("20")]
        public void IsFizzBuzz_GivenFive_ShouldReturnBuzz(string input)
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var expected = "Buzz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        
        [TestCase("15")]
        [TestCase("30")]
        [TestCase("75")]
        public void IsFizzBuzz_GivenFifteen_ShouldReturnFizzBuzz(string input)
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
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
