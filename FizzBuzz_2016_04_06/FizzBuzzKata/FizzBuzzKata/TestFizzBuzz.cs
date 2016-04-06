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
            var fizzBuzz = new FizzBuzz();
            var input = "1";
            var expected = "1";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);

            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
    }
}
