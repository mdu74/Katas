using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    class TestCalculator
    {
        [Test]
        public void Add_GivenEmptyInput_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var calculator = new Calculator();
            var expected = 0;
            var numbers = "";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

    }
}
