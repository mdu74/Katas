using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class TestFizzBuzz
    {
        [Test]
        public void IsFizzBuzz_GivenOne_ShouldReturnOne()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "1";
            var expected = "1";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenAnyNumberNotDivisibleByThreeOrFive_ShouldReturnsNumber()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "2";
            var expected = "2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenThree_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "3";
            var expected = "Fizz";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzz.IsFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzBuzz_GivenFive_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var fizzBuzz = CreateFizzBuzz();
            var input = "5";
            var expected = "Buzz";
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
