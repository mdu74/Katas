using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace fizzbuzz
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [Test]
        public void IsFizzBuzz_Given1_ShouldReturn1()
        {
            //arrange
            var input = "1";
            var fizzBuzz = CreateFizzBuzz();
            //act
            var result = fizzBuzz.IsFizzBuzz(input);
            //assert
            Assert.AreEqual(input, result);
        }

        [Test]
        public void IsFizzBuzz_Given2_ShouldReturn2()
        {
            //arrange
            var input = "2";
            var fizzBuzz = CreateFizzBuzz();
            //act
            var result = fizzBuzz.IsFizzBuzz(input);
            //assert
            Assert.AreEqual(input, result);
        }
      
        [TestCase("3")]
        [TestCase("6")]
        [TestCase("9")]
        public void IsFizzBuzz_GivenANumberDivisibleByThree_ShouldReturnFizz(string input)
        {
            //arrange
            var fizzBuzz = CreateFizzBuzz();
            //act
            var result = fizzBuzz.IsFizzBuzz(input);
            //assert
            Assert.AreEqual("Fizz", result);
        }

        [TestCase("5")]
        [TestCase("10")]
        [TestCase("20")]
        public void IsFizzBuzz_GivenANumberDivisibleByFive_ShouldReturnBuzz(string input)
        {
            //arrange
            var fizzBuzz = CreateFizzBuzz();
            //act
            var result = fizzBuzz.IsFizzBuzz(input);
            //assert
            Assert.AreEqual("Buzz", result);
        }
        
        [Test]
        public void IsFizzBuzz_Given10_ShouldReturnBuzz()
        {
            //arrange
            var fizzBuzz = CreateFizzBuzz();
            var input = "10";
            var expected = "Buzz";
            //act
            var result = fizzBuzz.IsFizzBuzz(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("15")]
        [TestCase("30")]
        [TestCase("75")]
        public void IsFizzBuzz_GivenANumberDivisibleByBothThreeAndFive_ShouldReturnFizzBuzz(string input)
        {
            //arrange
            var fizzBuzz = CreateFizzBuzz();
            //act
            var result = fizzBuzz.IsFizzBuzz(input);
            //assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void IsFizzBuzz_Given30_ShouldReturnFizzBuzz()
        {
            //arrange
            var fizzBuzz = CreateFizzBuzz();
            var input = "30";
            var expected = "FizzBuzz";
            //act
            var result = fizzBuzz.IsFizzBuzz(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        private static FizzBuzz CreateFizzBuzz()
        {
            return new FizzBuzz();
        }
    }
}
