using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}