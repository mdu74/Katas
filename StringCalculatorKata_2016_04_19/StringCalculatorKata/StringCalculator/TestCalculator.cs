using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    class TestCalculator
    {
        [Test]
        public void Add_GivenNoNumbers_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var calculator = new Calculator();
            var numbers = "";
            var expected = 0;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenSingleNumber_ShouldReturnNumber()
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

        private static Calculator CreateCalculator()
        {
            return new Calculator();
        }
    }
}
