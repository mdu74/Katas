using NUnit.Framework;

namespace StringCalculatorKata
{
    [TestFixture]
    class TestCalculator
    {
        [Test]
        public void Add_GivenEmptry_ShouldReturnZero()
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
