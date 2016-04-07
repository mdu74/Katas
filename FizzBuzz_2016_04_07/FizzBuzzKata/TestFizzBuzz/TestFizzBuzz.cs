
using NUnit.Framework;

namespace TestFizzBuzz
{
    public class TestFizzBuzz
    {
        [Test]
        public void IsFizzBuzz_GivenOne_ShouldReturnOne()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateIsFizzBuzz();
            var input = "1";

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------

            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
    }
}
