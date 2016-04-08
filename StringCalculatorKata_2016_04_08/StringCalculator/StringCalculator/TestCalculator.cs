
using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    public class TestCalculator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldZero()
        {
            //---------------Set up test pack-------------------
            var calculator = new Calculator();
            var input = "";
            var expected = 0;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

    }
}
