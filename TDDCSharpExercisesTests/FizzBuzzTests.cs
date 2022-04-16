using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TDDCSharpExercises;

namespace TDDCSharpExercisesTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void ReturnsNumberAsString()
        {
            Assert.AreEqual("-2", FizzBuzz.Run(-2));
            Assert.AreEqual("1", FizzBuzz.Run(1));
            Assert.AreEqual("2", FizzBuzz.Run(2));
        }

        [TestMethod]
        public void ReturnsFizzOnMultipleOfThree()
        {
            Assert.AreEqual("Fizz", FizzBuzz.Run(3));
            Assert.AreEqual("Fizz", FizzBuzz.Run(6));
        }

        [TestMethod]
        public void ReturnsBuzzOnMultipleOfFive()
        {
            Assert.AreEqual("Buzz", FizzBuzz.Run(5));
            Assert.AreEqual("Buzz", FizzBuzz.Run(10));
        }

        [TestMethod]
        public void ReturnsFizzBuzzOnMultipleOfFiveAndThree()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.Run(15));
            Assert.AreEqual("FizzBuzz", FizzBuzz.Run(30));
        }

        // Test For LeetCode solution

        [TestMethod]
        public void ReturnsNumbersForN2()
        {
            var fizzBuzzList = FizzBuzz.FizzBuzzLeet(2);
            var expectedResultsList = new List<string>() {"1", "2"};
            AssertListsEqual(expectedResultsList, fizzBuzzList);
        }

        [TestMethod]
        public void ReturnsNumbersForN3()
        {
            var fizzBuzzList = FizzBuzz.FizzBuzzLeet(3);
            var expectedResultsList = new List<string>() { "1", "2", "Fizz" };
            AssertListsEqual(expectedResultsList, fizzBuzzList);
        }

        [TestMethod]
        public void ReturnsNumbersForN5()
        {
            var fizzBuzzList = FizzBuzz.FizzBuzzLeet(5);
            var expectedResultsList = new List<string>() { "1", "2", "Fizz", "4", "Buzz" };
            AssertListsEqual(expectedResultsList, fizzBuzzList);
        }

        [TestMethod]
        public void ReturnsNumbersForN15()
        {
            var fizzBuzzList = FizzBuzz.FizzBuzzLeet(15);
            var expectedResultsList = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            AssertListsEqual(expectedResultsList, fizzBuzzList);
        }

        private void AssertListsEqual(IList<string> expected, IList<string> actual)
        {
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}