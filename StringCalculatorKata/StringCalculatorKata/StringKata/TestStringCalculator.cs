using NUnit.Framework;

namespace StringKata
{
    [TestFixture]
    public class TestStringCalculator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            //---------------Arrange-------------------
            var numbers = "";
            var stringCalculator = new StringCalculator();
            //---------------Act----------------
            var result = stringCalculator.Add(numbers);
            //---------------Assert ----------------------
            Assert.AreEqual(0, result);

        }

        [Test]
        public void Add_GivenSingleNumber_ShouldReturnSingleNumber()
        {
            //---------------Set up test pack-------------------
            var stringCalculator = new StringCalculator();
            var numbers = "3";
            var expected = 3;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
           
        }

        [Test]
        public void Add_GivenLargeNumber_ShouldReturnLargeNumber()
        {
            //---------------Set up test pack-------------------
            var stringCalculator = new StringCalculator();
            var numbers = "100";
            var expected = 100;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenTwoNumbers_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var stringCalculator = new StringCalculator();
            var numbers = "1,2";
            var expected = 3;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

    }
}
