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
            var calculator = CreateCalculator();
            var input = "";
            var expected = 0;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenSingleNumber_ShouldNumber()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            var expected = 2;
            var input = "2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        private static Calculator CreateCalculator()
        {
            return new Calculator();
        }
    }
}
