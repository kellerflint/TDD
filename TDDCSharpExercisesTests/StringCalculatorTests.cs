using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCSharpExercises;

namespace TDDCSharpExercisesTests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void ReturnsZeroForEmptyString()
        {
            Assert.AreEqual(0, StringCalculator.Run(""));
        }

        [TestMethod]
        public void ReturnsNumberForSingleInput()
        {
            Assert.AreEqual(1, StringCalculator.Run("1"));
            Assert.AreEqual(2, StringCalculator.Run("2"));
        }

        [TestMethod]
        public void ReturnsSumForDoubleInput()
        {
            Assert.AreEqual(2, StringCalculator.Run("1,1"));
            Assert.AreEqual(5, StringCalculator.Run("2,3"));
        }

        [TestMethod]
        public void ReturnsSumForNInputs()
        {
            Assert.AreEqual(3, StringCalculator.Run("1,1,1"));
            Assert.AreEqual(10, StringCalculator.Run("1,2,3,4"));
        }
    }
}
